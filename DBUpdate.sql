--**************************************************UPDATE***********************************************************************
--*********************************************************************************************************************************
--*********************************************************************************************************************************
GO
ALTER procedure [dbo].[eliminar_gasto_reparacion_vehiculo]
@idVehiculo int, @idGasto int,@mensaje int output
as
set @mensaje = 0
begin
	
	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo
	
	declare @idCP int= (select id from CuentasPagar where id_gasto = @idGasto)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 6
	delete from CuentasPagar where id = @idCP
	delete from GastoVehiculo where id = @idGasto and id_vehiculo =  @idVehiculo
	set @mensaje = 1
		
end

GO
ALTER procedure [dbo].[eliminar_componente_vehiculo]
@idVehiculo int, @idComponente int, @mensaje int output
as
set @mensaje = 0

begin

	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idComponente and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idComponente and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo

	declare @idCP int= (select id from CuentasPagar where id_gasto = @idComponente)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 5
	delete from CuentasPagar where id = @idCP

	delete from GastoVehiculo where id = @idComponente and id_vehiculo =  @idVehiculo
	
	set @mensaje = 1
		
end

GO
ALTER procedure [dbo].[eliminar_gasto_aduanal_vehiculo]
@idVehiculo int, @idGasto int,@mensaje int output
as
set @mensaje = 0
begin
	
	declare @precioRD float
	set @precioRD = (select monto_rd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	declare @precioUSD float 
	set @precioUSD = (select monto_usd from GastoVehiculo where id  = @idGasto and id_vehiculo =  @idVehiculo)
	

	update Vehiculos set total_invertido_rd = total_invertido_rd - @precioRD, total_invertido_usd = total_invertido_usd - @precioUSD
	where id = @idVehiculo

	declare @idCP int= (select id from CuentasPagar where id_gasto = @idGasto)
	
	delete from PagosCuentasPagar where id = @idCP
	delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo and id_transaccion = 7
	delete from CuentasPagar where id = @idCP

	delete from GastoVehiculo where id = @idGasto and id_vehiculo =  @idVehiculo
	set @mensaje = 1
		
end

GO
ALTER procedure [dbo].[obtener_vehiculo_gastos_aduanales]
@idVehiculo int
as


begin

	select G.descripcion as DESCRIPCION, TR.taller as TALLER ,GV.monto_rd as'PRECIO ($RD)', Gv.monto_usd as 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Gastos G on GV.id_gasto = G.id join TalleresRepuestos TR on GV.id_proveedor = TR.id
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 7
	
end


GO
ALTER procedure [dbo].[obtener_vehiculo_gastos_reparacion]
@idVehiculo int
as


begin

	select G.descripcion as DESCRIPCION, TR.taller as TALLER ,GV.monto_rd as'PRECIO ($RD)', Gv.monto_usd as 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Gastos G on GV.id_gasto = G.id join TalleresRepuestos TR on GV.id_proveedor = TR.id
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 6
	
end
GO

ALTER procedure [dbo].[obtener_vehiculo_componentes]
@idVehiculo int
as

begin
	
	select C.componente as DESCRIPCION, GV.monto_rd as'PRECIO ($RD)',GV.monto_usd 'PRECIO ($USD)' , GV.id as ID,
	GV.fecha as FECHA
	from GastoVehiculo GV join Componentes C on C.id = GV.id_gasto
	where GV.id_vehiculo = @idVehiculo and GV.id_transaccion = 5
	
end


GO
ALTER procedure [dbo].[reporte_resultados_usd]
@desde date, @hasta date
as

begin
	
	select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaUSD as PRECIOUSD,  V.total_invertido_usd as COSTOUSD,
	(V.precioVentaUSD - V.total_invertido_usd) as RESULTADOUSD,
	C.cliente as CLIENTE,
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 1),0) as EFECTIVO, 
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 2),0) as VRECIBIDO,
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 3),0) as CREDITO, 
	ISNULL((select monto_usd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 4),0) as OTROS
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id 
	join Clientes C on V.id_cliente = C.id 
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	where V.vendido = 1
	

end

Go
ALTER procedure [dbo].[reporte_resultados_rd]
@desde date, @hasta date
as

begin

	select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaRD as PRECIORD,  V.total_invertido_rd as COSTORD,
	(V.precioVentaRD - V.total_invertido_rd) as RESULTADORD,
	C.cliente as CLIENTE,
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 1),0) as EFECTIVO, 
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 2),0) as VRECIBIDO,
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 3),0) as CREDITO, 
	ISNULL((select monto_rd from FormaVentaVehiculo where id_transaccion = 1 and id_tipo_pago = 4),0) as OTROS
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id 
	join Clientes C on V.id_cliente = C.id 
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	where V.vendido = 1

end


GO
ALTER procedure [dbo].[reporte_cuentas_pagar]
@desde date, @hasta date, @idTransaccion int
as

begin

	
	if @idTransaccion = 2
		begin
			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION , V.fecha_importe as  FECHACOMPRA ,S.suplidor as PROPIETARIO,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Suplidores S on S.id = V.id_suplidor
			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
			join TipoTransaccion TP on TP.id = CP.id_transaccion
			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = @idTransaccion
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
		end
	 else if @idTransaccion = 4
		begin
			select CP.id as CUENTAPAGAR,TP.transaccion as TRANSACCION ,V.fecha_importe as  FECHACOMPRA ,S.nombre as PROPIETARIO,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			CP.monto_rd as TOTALPAGARRD, CP.monto_usd as TOTALPAGARUSD,
			(CP.monto_rd - CP.balance_rd) as PAGADORD, (CP.monto_usd - CP.balance_usd) as PAGADOUSD,
			CP.balance_rd as PENDIENTERD, CP.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'),
			format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE
			from CuentasPagar CP join Vehiculos V on V.id = CP.id_vehiculo join Seguros S on S.id = V.id_suplidor
			join Fabricantes F on F.id = V.fabricante_id join Modelos M on M.id = V.modelo_id
			join TipoTransaccion TP on TP.id = CP.id_transaccion
			where CP.balance_rd > 0 and CP.balance_usd > 0 and CP.id_transaccion = 4
			and format(CP.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
		end
end
	

Go
ALTER procedure [dbo].[obtener_recibos_cobros]
@desde date, @hasta date, @cliente varchar(50)
as

begin
	if @cliente = ''
		begin
			select V.id as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)', CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Vehiculos V on V.id = CC.id_vehiculo
			join Clientes C on C.id = V.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
		end
	else
		begin
			select V.id as 'ID VEHICULO',PCC.id as '# RECIBO', C.cliente as CLIENTE, PCC.monto_rd as 'MONTO ($RD)',
			PCC.monto_usd as 'MONTO $(USD)',CC.id as '# CUENTA COBRAR'
			from 
			PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar = CC.id join
			Vehiculos V on V.id = CC.id_vehiculo
			join Clientes C on C.id = V.id_cliente
			where format(PCC.fecha,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			and C.cliente LIKE '%' + @cliente + '%'
		end

end

GO
ALTER procedure [dbo].[reporte_cuentas_cobrar]
--@desde date, @hasta date
as

begin
	select  V.id as IDVEHICULO,V.fecha_vendido as  FECHAVENTA ,C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, V.vin as CHASIS,
			CC.monto_rd as TOTALPAGARRD, CC.monto_usd as TOTALPAGARUSD, (CC.monto_rd - CC.balance_rd ) as PAGADORD,(CC.monto_usd - CC.balance_usd )as PAGADOUSD,
			cc.balance_rd as PENDIENTERD, cc.balance_usd as PENDIENTEUSD,
			ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as DIASVIGENTE, CC.id as IDCUENTACOBRAR,
			TP.transaccion as TRANSACCION, CC.id_factura as 'FACTURA'
			from Vehiculos V 
			join Clientes C on C.id = V.id_cliente join Fabricantes F on F.id = V.fabricante_id 
			join Modelos M on M.id = V.modelo_id  
			join CuentasCobrar CC on CC.id_vehiculo = V.id
			join TipoTransaccion TP on TP.id = CC.id_transaccion
			where V.vendido = 1 and (CC.balance_rd != 0 and CC.balance_usd !=0  )
			
			--and format(CC.fecha,'yyyy-MM-dd') between
			--format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			
			GROUP BY C.cliente, CC.monto_rd, CC.monto_usd, CC.balance_rd, CC.balance_usd,
			F.fabricante, M.modelo, V.año, V.color, V.id, V.vin,V.fecha_vendido, CC.id, TP.transaccion,CC.id_factura
			order by DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
end

GO
ALTER procedure [dbo].[reporte_vehiculos_vendidos]
@desde date, @hasta date
as

begin
    -- FECHAVENDIDO
	
	Select format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaRD as PRECIORD,
	(ISNULL(SUM(PCC.monto_rd), 0) + (select sum(monto_rd) from FormaVentaVehiculo FV where FV.id_transaccion = 1 and Fv.id_tipo_pago !=3)) as PAGADORD ,
	V.precioVentaUSD as PRECIOUSD,
	(ISNULL(SUM(PCC.monto_usd), 0) + (select sum(monto_usd) from FormaVentaVehiculo FV where FV.id_transaccion = 1 and Fv.id_tipo_pago !=3)) as PAGADOUSD,
	C.cliente as CLIENTE
	from
	PagosCuentasCobrar PCC join CuentasCobrar CC on PCC.id_cuentaCobrar  = CC.id join Vehiculos V on V.id = CC.id_vehiculo
	join Modelos M on M.id = V.modelo_id join Fabricantes F on F.id = V.fabricante_id join Clientes C on C.id = V.id_cliente
	where V.vendido = 1
	and format(V.fecha_vendido,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	Group by V.fecha_vendido, F.fabricante, M.modelo, V.año, V.color, V.precioVentaRD, V.precioVentaUSD, C.cliente

end

GO

ALTER procedure [dbo].[reporte_obtener_detalle_cobros]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd  as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end

GO
ALTER procedure [dbo].[reporte_recibo_de_cobro]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
			
			--group by DPV.id, DPV.montoRD, DPV.montoUSD,  DPV.fechaPago, TP.formaPago, TFC.balanceRD,
			--TFC.balanceUSD 

		end
	
	
end

GO
ALTER procedure [dbo].[obtener_pagos_vehiculo]
@idVehiculo int, @idTransaccion int
as


begin
	select Format(V.fecha_importe,'dd/MM/yyyy') as 'FECHA DE PAGO', TP.formaPago as 'TIPO PAGO' ,
	FC.monto_rd as 'PAGO($RD)', FC.monto_usd as 'PAGO($USD)', FC.nota as 'DETALLE'
	from FormaCompraVehiculo FC join Vehiculos V on V.id = FC.id_vehiculo join TiposPago TP on TP.id = FC.id_tipo_pago
	where FC.id_vehiculo = @idVehiculo and FC.id_transaccion = @idTransaccion 
	
end


GO
ALTER procedure [dbo].[obtener_detalle_cuenta_por_pagar]
@idVehiculo int
as

begin
	

	select  distinct V.id as ID,
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_importe, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	Sup.suplidor as PROPIETARIO, Sup.direccion as DIRECCION, Sup.rnc_cedula as CEDULA, Sup.telefono as TEL ,
	format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
	V.precioRD as 'PRECIO ($RD)', V.precioUSD as 'PRECIO ($USD)', PS.precioRD as 'PRECIO SEGURO RD', PS.precioUSD as 'PRECIO SEGURO USD',
	S.nombre as 'SEGURO NOMBRE', S.telefono as 'SEGURO TEL'
	
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
	left join Suplidores Sup on V.id_suplidor = Sup.id left join PreciosSeguroVehiculo PS on PS.id_vehiculo = V.id
	left join SeguroVehiculo SV on SV.id_vehiculo = V.id left join Seguros S on S.id = SV.id_seguro
	
	where V.id = @idVehiculo
		
end


GO
ALTER procedure [dbo].[obtener_total_a_pagar_credito_vehiculo]
@idCP int
as

begin
	select monto_rd as 'CREDITO RD' , monto_usd as 'CREDITO USD' 
	from CuentasPagar where id = @idCP
		
			
end
GO
ALTER procedure [dbo].[registrar_pago_cuenta_pagar]
@idVehiculo int, @montoRD float, @montoUSD float, @detalles varchar(200), @mensaje bit output, @fecha date,
@idTipoPago int, @idCP int
as
set @mensaje = 0;
begin

	update CuentasPagar set balance_rd = balance_rd - @montoRD, balance_usd = balance_usd - @montoUSD where
	id_vehiculo = @idVehiculo and id = @idCP
	declare @balanceRD float= (Select balance_rd from CuentasPagar where id = @idCP)
	declare @balanceUSD float= (Select balance_usd from CuentasPagar where id = @idCP)

	insert into PagosCuentasPagar(id_cuentaPagar, monto_rd, monto_usd, nota, fecha, id_tipoPago, balance_rd, balance_usd)
	VALUES (@idCP, @montoRD, @montoUSD, @detalles, @fecha, @idTipoPago, @balanceRD, @balanceUSD)
	
	

	
	
	if @idTipoPago = 1
		begin
			insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
			values (@idVehiculo, 1, @montoRD, @montoUSD, @fecha, 'CxP RECIBO PAGO', (select MAX(id) from CuentasPagar))
		end

	set @mensaje = 1;
end

GO
ALTER procedure registrar_pago_cuenta_cobrar
@idVehiculo int, @montoRD float, @montoUSD float, @detalles varchar(200), @mensaje bit output, @fecha date,
@idTipoPago int, @idCC int
as
set @mensaje = 0;
begin
	
	
	update CuentasCobrar set balance_rd = balance_rd - @montoRD, balance_usd = balance_usd - @montoUSD where
	id_vehiculo = @idVehiculo and id = @idCC
	
	declare @balanceRD float= (Select balance_rd from CuentasCobrar where id = @idCC)
	declare @balanceUSD float= (Select balance_usd from CuentasCobrar where id = @idCC)

	insert into PagosCuentasCobrar(id_cuentaCobrar, monto_rd, monto_usd, nota, fecha, id_tipoPago, balance_rd, balance_usd)
	VALUES (@idCC, @montoRD, @montoUSD, @detalles, @fecha, @idTipoPago, @balanceRD, @balanceUSD)
	
	if @idTipoPago = 1
			begin
				 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
				 values (@idVehiculo, 2, @montoRD, @montoUSD, @fecha, 'CxC RECIBO PAGO', (select MAX(id) from CuentasCobrar))
			end
	set @mensaje = 1;
end

Go
ALTER procedure [dbo].[obtener_cobros_vehiculo]
@idVehiculo int, @idTransaccion int
as


begin
	select Format(V.fecha_importe,'dd/MM/yyyy') as 'FECHA DE PAGO', TP.formaPago as 'TIPO PAGO' ,
	FV.monto_rd as 'PAGO($RD)', FV.monto_usd as 'PAGO($USD)', FV.nota as 'DETALLE'
	from FormaVentaVehiculo FV join Vehiculos V on V.id = FV.id_vehiculo join TiposPago TP on TP.id = FV.id_tipo_pago
	where FV.id_vehiculo = @idVehiculo and FV.id_transaccion = @idTransaccion 
	
end



GO
ALTER procedure obtener_detalle_cuenta_por_cobrar
@idVehiculo int
as

begin
	
	select V.id as ID,
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) 
	as VEHICULO, V.vin as CHASIS, ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',	
	C.cliente as CLIENTE, C.direccion as DIRECCION, C.rnc_cedula as CEDULA, C.telefono as TEL ,
	format(V.fecha_vendido, 'dd/MM/yyyy' )as 'FECHA VENTA', 
	V.precioVentaRD as 'PRECIO ($RD)', V.precioVentaUSD as 'PRECIO ($USD)', PS.precioRD as 'PRECIO SEGURO RD',
	PS.precioUSD as 'PRECIO SEGURO USD', PT.precioRD as 'PRECIO TRASPASO RD',
	PT.precioUSD as 'PRECIO TRASPASO USD'
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Clientes C on V.id_cliente = C.id join PreciosSeguroVehiculo PS on PS.id_vehiculo = V.id
	join PreciosTraspasoVehiculo PT on PT.id_vehiculo = V.id
	where V.id = @idVehiculo and V.vendido = 1
		
end
Go

ALTER procedure obtener_total_a_cobrar_credito_vehiculo
@idCC int
as

begin
	select monto_rd as 'CREDITO RD' , monto_usd as 'CREDITO USD' 
	from CuentasCobrar where id = @idCC
		
			
end

GO
ALTER procedure obtener_cobros_credito_vehiculo
@idCC int
as

begin
	
			select format (PCC.fecha, 'dd/MM/yyyy') as 'FECHA PAGO', TP.formaPago as 'TIPO PAGO',PCC.monto_rd as 'PAGADO ($RD)', PCC.monto_usd as 'PAGADO ($USD)',
			PCC.nota as 'NOTA'
			from
			PagosCuentasCobrar PCC join TiposPago TP on TP.id = PCC.id_tipoPago
			where
			PCC.id_cuentaCobrar= @idCC
		
end
Go
ALTER procedure [dbo].[obtener_pagos_credito_vehiculo]
@idCP int
as

begin
	
		    select format (PCP.fecha, 'dd/MM/yyyy') as 'FECHA PAGO', TP.formaPago as 'TIPO PAGO',PCP.monto_rd as 'PAGADO ($RD)', PCP.monto_usd as 'PAGADO ($USD)',
			PCP.nota as 'NOTA'
			from PagosCuentasPagar PCP join TiposPago TP on TP.id = PCP.id_tipoPago
			where
			PCP.id_cuentaPagar = @idCP
			


		
end

GO
ALTER procedure obtener_cuentas_por_pagar
@propietario varchar(100), @desde date, @hasta date, @idTransaccion int
as



begin
	if @propietario = ''
		begin
			
			if @idTransaccion = 2
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end

			else if @idTransaccion = 4
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join Seguros S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
					
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end

			else if @idTransaccion = 5
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
			else if @idTransaccion = 6 
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					

					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
				
			else if @idTransaccion = 7
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
			
			
		end
	else
		begin
			if @idTransaccion = 2
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.suplidor as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join Suplidores S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
					and S.suplidor LIKE '%' + @propietario + '%'
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end

			else if @idTransaccion = 4
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.nombre as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join Seguros S on S.id = V.id_suplidor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0)
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') and CP.id_transaccion = @idTransaccion
					and S.nombre LIKE '%' + @propietario + '%'
					
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end

			else if @idTransaccion = 5
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 5
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					and S.taller LIKE '%' + @propietario + '%'
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
			else if @idTransaccion = 6 
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
					

					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 6
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					and S.taller LIKE '%' + @propietario + '%'
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
				
			else if @idTransaccion = 7
				begin 
					select  V.id as IDVEHICULO, CP.fecha as  'FECHA' ,TP.transaccion as TRANSACCION ,S.taller as 'PAGAR A',
					CONVERT(varchar(200),
					(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
					V.vin as CHASIS,
					ISNULL(CP.balance_rd, 0) as 'PENDIENTE ($RD)', ISNULL(CP.balance_usd, 0) as 'PENDIENTE ($USD)',
					ISNULL(DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'),
					 format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE', CP.id as IDCUENTAPAGAR
					from Vehiculos V  join CuentasPagar CP on CP.id_vehiculo = V.id
					join TalleresRepuestos S on S.id = CP.id_vendedor join Fabricantes F on F.id = V.fabricante_id 
					join Modelos M on M.id = V.modelo_id  join TipoTransaccion TP on TP.id = CP.id_transaccion
			
					where (ISNULL(CP.balance_usd,0) > 0 or ISNULL(CP.balance_rd,0)>0) and CP.id_transaccion = 7
					and format(CP.fecha,'yyyy-MM-dd') between
					format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd') 
					and S.taller LIKE '%' + @propietario + '%'
					order by DATEDIFF(DAY, format (CP.fecha, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
				end
		end
end


GO
ALTER procedure obtener_cuentas_por_cobrar
@cliente varchar(100), @desde date, @hasta date
as

begin
	if @cliente = ''
		begin

			select  V.id as IDVEHICULO, V.fecha_vendido as  'FECHA VENTA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Vehiculos V on CC.id_vehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on M.id = V.modelo_id
			where V.vendido = 1 and (CC.balance_rd > 0 and CC.balance_usd > 0)
			and format(V.fecha_vendido,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			order by DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
			 
		end
	else
		begin
			select  V.id as IDVEHICULO, V.fecha_vendido as  'FECHA VENTA', TP.transaccion as 'TRANSACCION',C.cliente as CLIENTE,
			CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
			V.vin as CHASIS, 
			CC.balance_rd as 'PENDIENTE ($RD)', CC.balance_usd as 'PENDIENTE ($USD)',
			ISNULL(DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')), 0) as 'DIAS VIGENTE',
			CC.id as IDCUENTACOBRAR
			From 
			CuentasCobrar CC join TipoTransaccion TP on TP.id = CC.id_transaccion join Clientes C on CC.id_cliente = C.id
			join Vehiculos V on CC.id_vehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on M.id = V.modelo_id
			where V.vendido = 1 and (CC.balance_rd > 0 and CC.balance_usd > 0)
			and format(V.fecha_vendido,'yyyy-MM-dd') between
			format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
			and C.cliente LIKE '%' + @cliente + '%'
			order by DATEDIFF(DAY, format (v.fecha_vendido, 'yyyy-MM-dd'), format (GETDATE(), 'yyyy-MM-dd')) DESC
			
		end
end

Go

ALTER procedure reporte_factura_obtener_monto_pendiente
@idVehiculo int
as

begin
	
	begin
		
		select ISNULL(sum(monto_rd), 0) as PENDIENTERD, ISNULL(sum(monto_usd), 0) as PENDIENTEUSD 
		from FormaVentaVehiculo
		where id_vehiculo = 1 and id_tipo_pago = 3
				
					
	
	end
	
end
Go
ALTER procedure obtener_facturas
@desde date, @hasta date
as

begin
	--select V.id, Fac.id as '# Factura', format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO, 
	--CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	--(V.precioVentaRD + PS.precioRD + PT.precioRD) as PRECIORD, sum(pa.monto_rd) as PAGADORD,
	--(V.precioVentaUSD + PS.precioUSD + PT.precioUSD) as PRECIOUSD, sum(pa.monto_usd) as PAGADOUSD, C.cliente as CLIENTE
	--from facturas Fac join Vehiculos V on Fac.idVehiculo = V.id join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	--join Propietarios P on V.id_propietario = P.id join FormaVentaVehiculo Pa on V.id=pa.id_vehiculo join Clientes C on V.id_cliente = C.id
	--join PreciosSeguroVehiculo PS on PS.id = Fac.idVehiculo join PreciosTraspasoVehiculo PT on PT.id_vehiculo = Fac.idVehiculo
	--where V.vendido = 1 
	----and format(V.fecha_importe,'yyyy-MM-dd') between
	----format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	--GROUP BY Fac.id ,V.id,V.precioVentaRD, PT.precioRD, PT.precioUSD, PS.precioRD, PS.precioUSD, V.precioVentaUSD ,F.fabricante, M.modelo, V.año, V.total_invertido_usd,V.total_invertido_rd ,V.fecha_vendido, C.cliente, V.color
	
	select F.id as '# Factura', format(V.fecha_vendido,'dd/MM/yyyy') as FECHAVENDIDO,
	CONVERT(varchar(200),(Fab.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	(V.precioVentaRD + PS.precioRD + PT.precioRD) as PRECIORD, (V.precioVentaUSD + PS.precioUSD + PT.precioUSD) as PRECIOUSD,
	C.cliente as CLIENTE
	from facturas F join Vehiculos V on V.id = F.idVehiculo join Fabricantes Fab on Fab.id = V.fabricante_id 
	join Modelos M on M.id = V.modelo_id join PreciosSeguroVehiculo PS on PS.id_vehiculo = F.idVehiculo 
	join PreciosTraspasoVehiculo PT on PT.id_vehiculo = F.idVehiculo join Clientes C on F.id_cliente = C.id
	where V.vendido = 1 and format(V.fecha_importe,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

end


Go
ALTER procedure reporte_individual_vehiculo_pagos
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 1	
	end
	
end

GO
if Not Exists(select * from sys.columns where Name = N'id_transaccion'  and Object_ID = Object_ID(N'DetallesEfectivoGeneral'))
	begin
		alter Table DetallesEfectivoGeneral
		add id_transaccion int
	end


GO
ALTER procedure vender_vehiculo
@idVehiculo int, @fecha date ,@mensaje int output, 
@idCliente int, @precioVentaRd float, @precioVentaUsd float,
@precioTraspasoRd float, @precioTraspasoUsd float, @precioSeguroRd float, @precioSeguroUsd float,
@idSeguro int, @duracion int
as
set @mensaje = 0



begin
		if (select vendido from Vehiculos where id = @idVehiculo) = 0
		 begin
			update Vehiculos set vendido = 1, fecha_vendido = @fecha, id_cliente = @idCliente,
			precioVentaRD = @precioVentaRd, precioVentaUSD = @precioVentaUsd
			where id = @idVehiculo

			insert into SeguroVehiculo (id_vehiculo, id_seguro, duracion_dias)
			Values (@idVehiculo, @idSeguro, @duracion)

			insert into PreciosTraspasoVehiculo(id_vehiculo,precioRD, precioUSD )
			Values (@idVehiculo, @precioTraspasoRd, @precioTraspasoUsd)

			insert into PreciosSeguroVehiculo(id_vehiculo,precioRD, precioUSD )
			Values (@idVehiculo, @precioSeguroRd, @precioSeguroUsd)
			
			insert into CuentasPagar(id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
			balance_rd, balance_usd, fecha, id_vehiculo)
			VALUES(0, @idCliente, 4, @precioSeguroRd, @precioSeguroUsd, @precioSeguroRd, @precioSeguroUsd,
			@fecha, @idVehiculo)

			insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
			VALUES (@idVehiculo, 4, 3, 0, @precioSeguroRd, @precioSeguroUsd, 'CUENTA PAGAR SEGURO', @fecha)
		set @mensaje = 1	

		 end
				
		--if @idTipoPago = 1
		--	begin
		--		 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento)
		--		 values (@idVehiculo, 2, @pagoRD, @pagoUSD, @fecha, 'Factura', (select id from facturas where id = (select max(id) from facturas)))
		--	end
				
end
go


ALTER procedure insertar_factura
@idVehiculo int, @mensaje int output, @idCliente int,
@fecha date
as
set @mensaje = 0
begin
	insert into facturas(idVehiculo, id_cliente, fecha) VALUES (@idVehiculo, @idCliente, @fecha)
	set @mensaje = 1
end

GO

ALTER Procedure borrar_venta_y_detalles_pagos
@idVehiculo int
as
--declare @idVehiculo int = 1;
begin

	update Vehiculos set vendido = 0, fecha_vendido = null, id_cliente = null,
			precioVentaRD = null, precioVentaUSD = null
			where id = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo
	Delete from CuentasCobrar where id_vehiculo = @idVehiculo
	delete from facturas where idVehiculo = @idVehiculo
	Delete from FormaVentaVehiculo where id_vehiculo = @idVehiculo
	Delete from DetallesEfectivoGeneral where idVehiculo = @idVehiculo
	Delete from SeguroVehiculo where id_vehiculo = @idVehiculo
	Delete from PreciosTraspasoVehiculo where id_vehiculo = @idVehiculo
	Delete from PreciosSeguroVehiculo where id_vehiculo = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo and id_transaccion = 4
	 

end
Go

ALTER Procedure borrar_compra_y_detalles_pagos
as

begin

	declare @idVehiculo int = (Select MAX(id) from Vehiculos)
	Delete from Vehiculos where id = @idVehiculo
	Delete from CuentasPagar where id_vehiculo = @idVehiculo
	Delete from FormaCompraVehiculo where id_vehiculo = @idVehiculo
	
end

GO
if Not Exists(select * from sys.columns where Name = N'id_cliente'  and Object_ID = Object_ID(N'facturas'))
	begin
		alter Table facturas
		add id_cliente int,
		fecha date	
	end

GO
ALTER procedure [dbo].[obtener_costo_chasis_vehiculo]
@idVehiculo int
as

begin
	
	select V.vin as VIN, 
	(V.total_invertido_rd) as COSTORD,
	(V.total_invertido_usd) as COSTOUSD,
	V.precio_estimado_rd as 'PRECIO VENTA ESTIMADO RD',
	V.precio_estimado_usd as 'PRECIO VENTA ESTIMADO USD'
	from  Vehiculos V where V.id = @idVehiculo
	
end
GO

ALTER procedure actualizar_vehiculo
@idVehiculo int,@vin varchar(50), @idPropietario int,
@nota varchar(250), @mensaje int output, @color varchar(50),
@idUbicacion varchar(50),
@matriculaOriginal bit, @cedulaVendedor bit, @actoVenta bit,
@rdPrecioVentaEstimado float,
@usdPrecioVentaEstimado float, @placa varchar(30), @numeroMatricula varchar(100), @millaje varchar(100),
@fuerzaMotriz varchar(30), @idSuplidor int, @año int, @fecha date
as
set @mensaje = 0

begin

    update Vehiculos set 
	id_propietario = @idPropietario, vin = @vin, nota = @nota,
	color = @color,id_ubicacion = @idUbicacion, 
    matricula =	@matriculaOriginal, acto_venta = @actoVenta, cedula_vendedor =  @cedulaVendedor,
	precio_estimado_rd = @rdPrecioVentaEstimado, precio_estimado_usd = @usdPrecioVentaEstimado, 
	placa = @placa, numero_matricula = @numeroMatricula,
	millaje = @millaje, fuerza_motriz = @fuerzaMotriz, id_suplidor = @idSuplidor, año = @año
	where id = @idVehiculo
	
	declare @ultimaUbicacion int= (SELECT TOP 1 id_ubicacion FROM HistorialUbicaciones where id_vehiculo = @idVehiculo ORDER BY ID DESC)
	if @ultimaUbicacion != @idUbicacion
		begin
			insert into HistorialUbicaciones(id_vehiculo,id_ubicacion, fecha) 
			Values (@idVehiculo, @idUbicacion, @fecha)
		end
	set @mensaje = 1
end

GO

ALTER procedure obtener_detalle_vehiculo_especifico
@idVehiculo int
as

begin
	
	select V.id as ID,F.fabricante as FABRICANTE, M.modelo as MODELO, V.año as AÑO, P.nombre as PROPIETARIO, 
	 V.vin as VIN, V.nota as NOTA, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRADO', V.terminado as TERMINADO,
	 V.fecha_vendido as 'FECHA VENDIDO', V.precioRD as 'PRECIO ($RD)',
	 V.precioUSD as 'PRECIO ($USD)', V.vendido as VENDIDO, V.pagado as PAGADO, V.color as COLOR, V.nota as DETALLES,
	 V.acto_venta as 'ACTO VENTA', V.matricula as 'MATRICULA ORIGINAL', v.cedula_vendedor as 'CEDULA VENDEDOR',
	 U.ubicacion as UBICACION, format(V.fecha_terminado, 'dd/MM/yyyy' )as 'FECHA TERMINADO', S.suplidor as SUPLIDOR,
	 V.placa as PLACA, V.numero_matricula as 'NUMERO MATRICULA', V.millaje as MILLAJE, V.precio_estimado_rd as 'PRECIO ESTIMADO RD',
	 V.precio_estimado_usd as 'PRECIO ESTIMADO USD', V.fuerza_motriz as 'FUERZA MOTRIZ'
	from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion
	join Suplidores S on S.id = V.id_suplidor
	where V.id = @idVehiculo
		
end



GO
ALTER procedure obtener_vehiculos
@tipo varchar(50), @desde date, @hasta date
as
/*
format(@desde,'dd/MM/yyyy') and format(@hasta,'dd/MM/yyyy')
*/

begin
	if @tipo = 'proceso'
		begin
			select V.id as ID,F.fabricante as MARCA, M.modelo as MODELO, V.año as AÑO, V.color as COLOR ,total_invertido_rd as 'COSTO ($RD)',
			total_invertido_usd as 'COSTO($USD)' , P.nombre as PROPIETARIO, 
			V.vin as VIN, V.nota as DETALLES, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRA', V.acto_venta as 'ACTO DE VENTA',
			v.matricula as 'MATRICULA ORIGINAL', V.cedula_vendedor as 'CEDULA VENDEDOR', U.ubicacion as 'UBICACION',  S.suplidor as SUPLIDOR, 
			V.numero_matricula as '#Matrícula', V.placa as PLACA, V.millaje as MILLAJE, 
			v.fuerza_motriz as 'FUERZA MOTRIZ'
			from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
			join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion 
			join Suplidores S on S.id = V.id_suplidor
			where format(V.fecha_importe,'yyyy-MM-dd')  between  format(@desde,'yyyy-MM-dd') and format(@hasta,'yyyy-MM-dd')
			and V.terminado = 0 and V.vendido = 0 and V.estado = 1
			ORDER By ID DESC
		end
	else if @tipo = 'terminado'
		begin
			select V.id as ID,F.fabricante as MARCA, M.modelo as MODELO, V.año as AÑO, V.color as COLOR ,total_invertido_rd as 'COSTO($RD)',
			total_invertido_usd as 'COSTO($USD)' , P.nombre as PROPIETARIO, 
			V.vin as VIN, V.nota as DETALLES, format(V.fecha_importe, 'dd/MM/yyyy' )as 'FECHA COMPRADO', 
			format(V.fecha_terminado, 'dd/MM/yyyy' )as 'FECHA INVENTARIO' , V.acto_venta as 'ACTO DE VENTA',
			v.matricula as 'MATRICULA ORIGINAL', V.cedula_vendedor as 'CEDULA VENDEDOR', U.ubicacion as 'UBICACION',  S.suplidor as SUPLIDOR, 
			V.numero_matricula as '#Matrícula', V.placa as PLACA, V.millaje as MILLAJE, 
			v.fuerza_motriz as 'FUERZA MOTRIZ'  
			from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
			join Propietarios P on V.id_propietario = P.id join Ubicaciones U on U.id = V.id_ubicacion
			join Suplidores S on S.id = V.id_suplidor
			where format(V.fecha_importe,'yyyy-MM-dd')  between  format(@desde,'yyyy-MM-dd') and format(@hasta,'yyyy-MM-dd')
			and V.terminado = 1 and vendido = 0 and V.estado = 1
			ORDER By ID DESC
		end
	end


GO
ALTER procedure registrar_vehiculo
@idFabricante int, @idModelo int, @año int, @precioUsd float,@vin varchar(50), @idPropietario int, @fecha date,
@nota varchar(250),@precioRd float, @mensaje int output, @color varchar(50),
@matriculaOriginal bit, @cedulaVendedor bit, @actoVenta bit, @idUbicacion int, @rdPrecioVentaEstimado float,
@usdPrecioVentaEstimado float, @placa varchar(30), @numeroMatricula varchar(100), @millaje varchar(100),
@fuerzaMotriz varchar(30), @idSuplidor int

as
set @mensaje = 0

begin

	insert into Vehiculos(fabricante_id, modelo_id, año, precioUSD, precioRD, id_propietario, terminado, 
	vendido, pagado, fecha_importe, vin, nota, estado,total_invertido_rd, total_invertido_usd, color, matricula, acto_venta, cedula_vendedor, id_ubicacion,
	precio_estimado_rd, precio_estimado_usd, placa, numero_matricula, millaje, fuerza_motriz, id_suplidor)
	VALUES(@idFabricante, @idModelo, @año, @precioUsd, @precioRd, @idPropietario, 0,0,0,@fecha, @vin, @nota, 1, @precioRd,
	@precioUsd, @color, @matriculaOriginal, @actoVenta, @cedulaVendedor, @idUbicacion, @rdPrecioVentaEstimado, @usdPrecioVentaEstimado,
	@placa, @numeroMatricula, @millaje, @fuerzaMotriz, @idSuplidor)
	
	insert into HistorialUbicaciones(id_vehiculo, id_ubicacion, fecha)
	values ((SELECT MAX(id) from Vehiculos), @idUbicacion, @fecha)
	set @mensaje = 1
end
Go

if Not Exists(select * from sys.columns where Name = N'id_ubicacion'  and Object_ID = Object_ID(N'Vehiculos'))
	begin
		ALTER TABLE Vehiculos DROP COLUMN ubicacion
		
		alter Table Vehiculos 
		Add id_suplidor int,
		id_ubicacion int ,
		precio_estimado_rd decimal(18,2),
		precio_estimado_usd decimal(18,2),
		placa varchar(30),
		numero_matricula varchar(100),
		millaje varchar(100),
		fuerza_motriz varchar(30)	
	end

GO
if Not Exists(select * from sys.columns where Name = N'agregar_paises'  and Object_ID = Object_ID(N'Usuarios'))
	begin
		alter Table Usuarios 
		Add agregar_paises bit NOT NULL DEFAULT 1,
		agregar_ciudades bit NOT NULL DEFAULT 1,
		agregar_colores bit NOT NULL DEFAULT 1,
		agregar_ubicaciones bit NOT NULL DEFAULT 1,
		agregar_suplidores bit NOT NULL DEFAULT 1,
		agregar_seguros bit NOT NULL DEFAULT 1
		
	end

GO

ALTER procedure registrar_usuarios
@usuario varchar(50), @nombre varchar(50), @clave varchar(50), @tasaDolar bit, @crearUsuarios bit,
@fabricantesModelos bit, @piezasRepuestos bit, @crearTaller bit, @crearPropietarios bit, @crearClientes bit, 
@crearGastos bit, @importarVehiculos bit, @compras bit, @cambiarEstadosVehiculos bit, @agregarGastos bit,
@agregarPiezas bit, @facturacion bit, @reportes bit, @estado bit, @mensaje int output, @modificarVehiculo bit, 
@cuentasPagar bit, @cuentasCobrar bit, @actualizarTasaDiario bit, @crearPais bit, @crearCiudad bit, @crearSuplidor bit,
@crearColor bit, @crearUbicacion bit, @crearSeguros bit
as
set @mensaje = 0

begin

	if not exists(select * from Usuarios where usuario = @usuario)
		begin
			insert into Usuarios(usuario, clave, nombreApellido, tasaDolar, crearUsuarios, fabricantesModelos,
			 piezasRepuestos, crearTaller, crearPropietarios, crearClientes, crearGastos, importarVehiculo, 
			 compras, cambiarEstadosVehiculo, agreagarGastos, agregarPiezas, facturacion, reportes, estadoUsuario,
			 modificarVehiculo, cuentasCobrar, cuentasPagar, actualizarDiarioTasa, agregar_paises, agregar_ciudades,
			 agregar_suplidores, agregar_colores, agregar_ubicaciones, agregar_seguros) 
			VALUES(@usuario, @clave, @nombre, @tasaDolar, @crearUsuarios, @fabricantesModelos, @piezasRepuestos,
			@crearTaller, @crearPropietarios, @crearClientes, @crearGastos, @importarVehiculos, @compras,
			@cambiarEstadosVehiculos, @agregarGastos, @agregarPiezas, @facturacion, @reportes, @estado, @modificarVehiculo,
			@cuentasCobrar, @cuentasPagar, @actualizarTasaDiario, @crearPais, @crearCiudad, @crearSuplidor, @crearColor,
			@crearUbicacion, @crearSeguros) 
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end

GO
ALTER procedure actualizar_usuarios
@usuario varchar(50), @nombre varchar(50), @clave varchar(50), @tasaDolar bit, @crearUsuarios bit,
@fabricantesModelos bit, @piezasRepuestos bit, @crearTaller bit, @crearPropietarios bit, @crearClientes bit, 
@crearGastos bit, @importarVehiculos bit, @compras bit, @cambiarEstadosVehiculos bit, @agregarGastos bit,
@agregarPiezas bit, @facturacion bit, @reportes bit, @estado bit, @mensaje int output, @idUsuario int,
@modificarVehiculo bit, @cuentasPagar bit, @cuentasCobrar bit, @actualizarTasaDiario bit, @crearPais bit, @crearCiudad bit, @crearSuplidor bit,
@crearColor bit, @crearUbicacion bit, @crearSeguros bit
as
set @mensaje = 0

begin

	if not exists(select * from Usuarios where usuario = @usuario and id != @idUsuario)
		begin
			update Usuarios set usuario = @usuario, clave = @clave, nombreApellido = @nombre, tasaDolar = @tasaDolar, 
			crearUsuarios = @crearUsuarios, fabricantesModelos = @fabricantesModelos, piezasRepuestos = @piezasRepuestos, 
			crearTaller = @crearTaller, crearPropietarios = @crearPropietarios, crearClientes = @crearClientes, 
			crearGastos = @crearGastos, importarVehiculo = @importarVehiculos, compras = @compras, 
			cambiarEstadosVehiculo = @cambiarEstadosVehiculos, agreagarGastos = @agregarGastos, agregarPiezas = @agregarPiezas, 
			facturacion = @facturacion, reportes = @reportes, estadoUsuario = @estado, modificarVehiculo = @modificarVehiculo,
			cuentasCobrar = @cuentasCobrar, cuentasPagar = @cuentasPagar, actualizarDiarioTasa = @actualizarTasaDiario,
			agregar_paises = @crearPais, agregar_ciudades = @crearCiudad, agregar_suplidores = @crearSuplidor,
			agregar_colores = @crearColor, agregar_ubicaciones = @crearUbicacion, agregar_seguros = @crearSeguros
			
			where id = @idUsuario
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end

GO

ALTER procedure obtener_todos_usuarios
as
begin

	select id as ID, usuario as USUARIO, nombreApellido as NOMBRE, tasaDolar as 'TASA CAMBIO', 
	crearUsuarios as 'CREAR USUARIOS', fabricantesModelos as 'CREAR FABRICANTES/MODELOS',
	piezasRepuestos as 'CREAR PIEZAS/REPUESTOS', crearTaller as 'CREAR TALLER', crearPropietarios as 'CREAR PROPIETARIOS', 
	crearClientes as 'CREAR CLIENTES',crearGastos as 'CREAR GASTOS', importarVehiculo 'VEHICULOS INVENTARIO', 
	compras as 'COMPRAS', cambiarEstadosVehiculo as 'CAMBIAR ESTADO VEHICULOS',
	agreagarGastos as 'AGREGAR GASTO A VEHICULO', agregarPiezas as 'AGREGAR PIEZAS A VEHICULO', 
	facturacion as 'FACTURACION',modificarVehiculo as 'MODIFICAR VEHICULO', cuentasPagar as 'CUENTAS PAGAR' ,cuentasCobrar as 'CUENTAS COBRAR',
	reportes as REPORTES, actualizarDiarioTasa as 'ACTUALIZAR TASA DIARIO' ,estadoUsuario as 'ESTADO USUARIO', clave as CLAVE,
	agregar_paises as 'AGREGAR PAISES', agregar_ciudades as 'AGREGAR CIUDADES', agregar_colores as 'AGREGAR COLORES',
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES', agregar_seguros as 'AGREGAR SEGUROS'
	from Usuarios where id != 1
	
end

GO
ALTER procedure obtener_permiso_usuario
@idUsuario int
as


begin

	select tasaDolar as 'TASA CAMBIO', 
	crearUsuarios as 'CREAR USUARIOS', fabricantesModelos as 'CREAR FABRICANTES/MODELOS',
	piezasRepuestos as 'CREAR PIEZAS/REPUESTOS', crearTaller as 'CREAR TALLER', crearPropietarios as 'CREAR PROPIETARIOS', 
	crearClientes as 'CREAR CLIENTES',crearGastos as 'CREAR GASTOS', importarVehiculo 'IMPORTAR VEHICULOS', 
	compras as 'COMPRAS', cambiarEstadosVehiculo as 'CAMBIAR ESTADO VEHICULOS',
	agreagarGastos as 'AGREGAR GASTO A VEHICULO', agregarPiezas as 'AGREGAR PIEZAS A VEHICULO', 
	facturacion as 'FACTURACION', reportes as REPORTES, estadoUsuario as 'ESTADO USUARIO', modificarVehiculo as 'MODIFICAR VEHICULO',
	cuentasCobrar as 'CUENTAS COBRAR', cuentasPagar as 'CUENTAS PAGAR', actualizarDiarioTasa 'ACTUALIZAR TASA DIARIO',
	agregar_paises as 'AGREGAR PAISES', agregar_ciudades as 'AGREGAR CIUDADES', agregar_colores as 'AGREGAR COLORES',
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES', agregar_seguros as 'AGREGAR SEGUROS'
	from Usuarios where id = @idUsuario
	
end

Go

if Not Exists(select * from sys.columns where Name = N'id_pais'  and Object_ID = Object_ID(N'Clientes'))
	begin
		alter Table Clientes Add id_pais int, id_ciudad int
	end


GO
ALTER procedure registrar_cliente
@cliente varchar(200), @cedulaRNC varchar(50), @tel varchar(50), @estado bit, @mensaje int output, @direccion varchar(200),
@idPais int, @idCiudad int
as
set @mensaje = 0

begin

	if not exists(select * from Clientes where cliente = @cliente or rnc_cedula = @cedulaRNC)
		begin
			insert into Clientes(cliente, rnc_cedula, telefono, estado, direccion, id_pais, id_ciudad)
			VALUES (@cliente, @cedulaRNC, @tel, @estado, @direccion, @idPais, @idCiudad)
			set @mensaje = 1

		end

	else
		begin 
			set @mensaje = 2
		end
end

GO
ALTER procedure actualizar_cliente
@idCliente int,@cliente varchar(200), @cedulaRNC varchar(50), @tel varchar(50), @estado bit, @mensaje int output,
@direccion varchar(200), @idPais int, @idCiudad int
as
set @mensaje = 0

begin

	
	update Clientes set cliente = @cliente, rnc_cedula = @cedulaRNC, telefono = @tel, estado = @estado, 
	direccion = @direccion, id_pais = @idPais, id_ciudad = @idCiudad
	where id = @idCliente
	set @mensaje = 1

end

GO
ALTER procedure obtener_todos_clientes
as
begin

	select C.id as ID, C.cliente as CLIENTE, C.rnc_cedula as 'RNC/CEDULA', C.direccion as DIRECCION ,
	telefono as 'TEL.',P.pais as PAIS, Ci.ciudad as CIUDAD ,C.estado as HABILITADO
	
	from Clientes C left join Paises P on P.id = C.id_pais left join Ciudades Ci on Ci.id = C.id_ciudad
	
end


--***********************************************NEW*********************************************************************
--*************************************************************************************************************************
--*************************************************************************************************************************
GO
Drop table ImagenesClientes 
GO

if not exists (select * from sysobjects where name='ImagenesClientes' and xtype='U')
	BEGIN
		CREATE TABLE ImagenesClientes (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		idCliente int,
		img varbinary(MAX)
		);
	END



GO
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertar_imagenes_clientes' AND type = 'P')
DROP PROCEDURE insertar_imagenes_clientes 
GO
create procedure insertar_imagenes_clientes
@img varbinary(max), @mensaje int output
as
set @mensaje = 0;
declare @idCliente int = (select MAX(id) from Clientes)
begin
	insert into ImagenesClientes(idCliente,img)
	Values (@idCliente, @img)
	set @mensaje = 1;
	
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_imagenes_clientes' AND type = 'P')
DROP PROCEDURE actualizar_imagenes_clientes
Go

create procedure actualizar_imagenes_clientes
@img varbinary(max), @mensaje int output, @idCliente int
as
set @mensaje = 0;

begin
	insert into ImagenesClientes(idCliente,img)
	Values (@idCliente, @img)
	set @mensaje = 1;
	
end
GO

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'borrar_imagen_cliente' AND type = 'P')
DROP PROCEDURE borrar_imagen_cliente 
GO

create procedure [dbo].[borrar_imagen_cliente]
@id int, @mensaje int output
as
set @mensaje = 0;
begin
	delete from ImagenesClientes where id = @id
	set @mensaje = 1;
end

GO
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_imagenes_clientes' AND type = 'P')
DROP PROCEDURE obtener_imagenes_clientes 
GO
create procedure obtener_imagenes_clientes 
@idCliente  int
as
begin
	select id,img from ImagenesClientes where idCliente = @idCliente
	
end

Go
Drop table Paises
go
if not exists (select * from sysobjects where name='Paises' and xtype='U')
	BEGIN
		CREATE TABLE Paises (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		pais varchar(100),
		estado bit
		);
	END

	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_pais' AND type = 'P')
	DROP PROCEDURE registrar_pais
	GO

	create procedure registrar_pais
	@pais varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Paises (pais,estado)
		Values (@pais, @estado)
		set @mensaje = 1;
	
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_paises' AND type = 'P')
	DROP PROCEDURE obtener_todos_paises
	GO
	create procedure obtener_todos_paises
	as
	
	begin
		select id as ID, pais as PAIS, estado as ESTADO from Paises 
	end
	Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_pais' AND type = 'P')
	DROP PROCEDURE actualizar_pais
	GO

	create procedure actualizar_pais
	@idPais int, @pais varchar(100), @estadoPais bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Paises set pais = @pais, estado = @estadoPais where id = @idPais
		set @mensaje = 1
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_paises_activos' AND type = 'P')
	DROP PROCEDURE obtener_paises_activos
	GO

	create procedure obtener_paises_activos
	as
	
	begin
		select id as ID, pais as PAIS, estado as ESTADO from Paises  where estado = 1
	end
	Go

	Drop Table Ciudades
	GO

	if not exists (select * from sysobjects where name='Ciudades' and xtype='U')
	BEGIN
		CREATE TABLE Ciudades (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		idPais int,
		ciudad varchar(100),
		estado bit
		);
	END
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_ciudad' AND type = 'P')
	DROP PROCEDURE registrar_ciudad
	GO

	create procedure registrar_ciudad
	@idPais int,@ciudad varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Ciudades(idPais,ciudad,estado)
		Values (@idPais,@ciudad ,@estado)
		set @mensaje = 1;
	
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_ciudades' AND type = 'P')
	DROP PROCEDURE obtener_todos_ciudades
	GO

	create procedure obtener_todos_ciudades
	@idPais int
	as
	
	begin
		select id as ID, ciudad as CIUDAD, estado as ESTADO from Ciudades
		where idPais = @idPais
	end
	Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_ciudad' AND type = 'P')
	DROP PROCEDURE actualizar_ciudad
	GO

	create procedure actualizar_ciudad
	@idCiudad int, @idPais int, @ciudad varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Ciudades set ciudad = @ciudad, estado = @estado, idPais = @idPais where id = @idCiudad
		set @mensaje = 1
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_ciudades_activos' AND type = 'P')
	DROP PROCEDURE obtener_ciudades_activos
	GO

	create procedure obtener_ciudades_activos
	@idPais int
	as
	
	begin
		select id as ID, ciudad as CIUDAD, estado as ESTADO from Ciudades  where estado = 1 and idPais = @idPais
	end

	Go

	
Drop table Colores
go
if not exists (select * from sysobjects where name='Colores' and xtype='U')
	BEGIN
		CREATE TABLE Colores (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		color varchar(100),
		estado bit
		);
	END
Go
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_color' AND type = 'P')
	DROP PROCEDURE registrar_color
	GO

	create procedure registrar_color
	@color varchar(100), @estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Colores (color,estado)
		Values (@color, @estado)
		set @mensaje = 1;
	
	end

	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_colores' AND type = 'P')
	DROP PROCEDURE obtener_todos_colores
	GO
	create procedure obtener_todos_colores
	as
	
	begin
		select id as ID, color as COLOR, estado as ESTADO from Colores 
	end
	Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_color' AND type = 'P')
	DROP PROCEDURE actualizar_color
	GO
	

	create procedure actualizar_color
	@idColor int, @color varchar(100), @estadoColor bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Colores set color = @color, estado = @estadoColor where id = @idColor
		set @mensaje = 1
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_colores_activos' AND type = 'P')
	DROP PROCEDURE obtener_colores_activos
	GO

	create procedure obtener_colores_activos
	as
	
	begin
		select id as ID, color as COLOR, estado as ESTADO from Colores  where estado = 1
	end

	Go

Drop table Ubicaciones
go
if not exists (select * from sysobjects where name='Ubicaciones' and xtype='U')
	BEGIN
		CREATE TABLE Ubicaciones (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_pais int,
		id_ciudad int,
		ubicacion  varchar(100),
		estado bit
		);
	END
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_ubicacion' AND type = 'P')
	DROP PROCEDURE registrar_ubicacion
	GO

	create procedure registrar_ubicacion
	@ubicacion varchar(100),@idPais int, @idCiudad int ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Ubicaciones(id_pais, id_ciudad, ubicacion, estado)
		Values (@idPais, @idCiudad, @ubicacion ,@estado)
		set @mensaje = 1;
	
	end

GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_ubicaciones' AND type = 'P')
	DROP PROCEDURE obtener_todos_ubicaciones
	GO
	create procedure obtener_todos_ubicaciones
	as
	
	begin
		select U.id as ID, P.pais as PAIS, C.ciudad as CIUDAD, U.ubicacion as LUGAR, U.estado as ESTADO
		from Ubicaciones U join Paises P on P.id = U.id_pais
		join Ciudades C on C.id = U.id_ciudad
	end
	Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_ubicacion' AND type = 'P')
	DROP PROCEDURE actualizar_ubicacion
	GO
	

	create procedure actualizar_ubicacion
	@idUbicacion int, @ubicacion varchar(100), @estadoUbicacion bit, @mensaje int output, @idPais int,
	@idCiudad int
	as
	set @mensaje = 0
	begin
		Update Ubicaciones set ubicacion = @ubicacion, estado = @estadoUbicacion,
		id_pais = @idPais, id_ciudad = @idCiudad 
		where id = @idUbicacion
		set @mensaje = 1
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_ubicaciones_activos' AND type = 'P')
	DROP PROCEDURE obtener_ubicaciones_activos
	GO

	create procedure obtener_ubicaciones_activos
	as
	
	begin
		select id as ID, ubicacion as LUGAR, estado as ESTADO from Ubicaciones  where estado = 1
	end

	Go


Drop table Suplidores
go
if not exists (select * from sysobjects where name='Suplidores' and xtype='U')
	BEGIN
		CREATE TABLE Suplidores (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		suplidor varchar(100),
		rnc_cedula varchar(100),
		id_pais int,
		id_ciudad int,
		direccion varchar(100),
		telefono varchar(100),
		estado bit
		);
	END
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_suplidor' AND type = 'P')
	DROP PROCEDURE registrar_suplidor
	GO

	create procedure registrar_suplidor
	@suplidor varchar(100), @rnc_cedula varchar(100), @idPais int, @idCiudad int , @direccion varchar(100),
	@telefono varchar(100) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Suplidores(suplidor, rnc_cedula,id_pais, id_ciudad, direccion, telefono, estado)
		Values (@suplidor,@rnc_cedula,@idPais, @idCiudad, @direccion ,@telefono ,@estado)
		set @mensaje = 1;
	
	end

GO
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_suplidores' AND type = 'P')
	DROP PROCEDURE obtener_todos_suplidores
	GO
	create procedure obtener_todos_suplidores
	as
	
	begin
		select S.id as ID,S.suplidor as SUPLIDOR,S.rnc_cedula as 'RNC/CEDULA' ,P.pais as PAIS, C.ciudad as CIUDAD,
		 S.direccion as DIRECCION,S.telefono ,S.estado as ESTADO
		from Suplidores S join Paises P on P.id = S.id_pais
		join Ciudades C on C.id = S.id_ciudad
	end
Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_suplidores_activos' AND type = 'P')
	DROP PROCEDURE obtener_suplidores_activos
	GO

	create procedure obtener_suplidores_activos
	as
	
	begin
		select id as ID, suplidor as SUPLIDOR, estado as ESTADO from Suplidores  where estado = 1
	end

Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_suplidor' AND type = 'P')
	DROP PROCEDURE actualizar_suplidor
	GO

	create procedure actualizar_suplidor
	@idSuplidor int, @suplidor varchar(100), @rnc_cedula varchar(100), @idPais int, @idCiudad int , @direccion varchar(100),
	@telefono varchar(100) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		Update Suplidores set suplidor = @suplidor, rnc_cedula = @rnc_cedula, id_pais = @idPais, 
		id_ciudad = @idCiudad, direccion = @direccion, telefono = @telefono, estado = @estado
		where id = @idSuplidor
		set @mensaje = 1;
	
	end

GO



Drop table HistorialUbicaciones
go
if not exists (select * from sysobjects where name='HistorialUbicaciones' and xtype='U')
	BEGIN
		CREATE TABLE HistorialUbicaciones (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_ubicacion int,
		fecha date
		);
	END
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_historial_ubicaciones' AND type = 'P')
	DROP PROCEDURE obtener_historial_ubicaciones
	GO
	create procedure obtener_historial_ubicaciones
	@idVehiculo int
	as
	
	begin
		select format(HU.fecha, 'dd/MM/yyyy' ) as  FECHA ,U.ubicacion as UBICACION
		from HistorialUbicaciones HU join Ubicaciones U on U.id = HU.id_ubicacion
		where HU.id_vehiculo = @idVehiculo
		 
	end
Go

Drop table TipoTransaccion
go
if not exists (select * from sysobjects where name='TipoTransaccion' and xtype='U')
	BEGIN
		CREATE TABLE TipoTransaccion (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		transaccion varchar(100)
		);
		insert into TipoTransaccion(transaccion)
		Values ('VENTA'),('COMPRA'),('TRASPASO'), ('SEGURO'), ('PIEZAS'),('TALLER MECANICO'), ('OTROS')
	END
Go

Drop table FormaVentaVehiculo
go
if not exists (select * from sysobjects where name='FormaVentaVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE FormaVentaVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_transaccion int,
		id_tipo_pago int,
		id_factura int,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		nota varchar(100),
		fecha date
		);
		
	END
Go

Drop table FormaCompraVehiculo
go
if not exists (select * from sysobjects where name='FormaCompraVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE FormaCompraVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_transaccion int,
		id_tipo_pago int,
		id_factura int,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		nota varchar(100),
		fecha date
		);
		
	END
Go


Drop table CuentasCobrar
go
if not exists (select * from sysobjects where name='CuentasCobrar' and xtype='U')
	BEGIN
		CREATE TABLE CuentasCobrar (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_factura int,
		id_cliente int,
		id_transaccion int,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		balance_rd decimal (18,2),
		balance_usd decimal (18,2),
		fecha date
		);
		
	END

Go

Drop table CuentasPagar
go
if not exists (select * from sysobjects where name='CuentasPagar' and xtype='U')
	BEGIN
		CREATE TABLE CuentasPagar (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_factura int,
		id_vendedor int,
		id_transaccion int,
		id_gasto int default 0,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		balance_rd decimal (18,2),
		balance_usd decimal (18,2),
		fecha date
		);
		
	END

Go

Drop table PagosCuentasCobrar
go
if not exists (select * from sysobjects where name='PagosCuentasCobrar' and xtype='U')
	BEGIN
		CREATE TABLE PagosCuentasCobrar (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_cuentaCobrar int,
		id_tipoPago int,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		fecha date,
		nota varchar(100),
		balance_rd decimal (18,2),
		balance_usd decimal (18,2)
		);
		
	END
Go

Drop table PagosCuentasPagar
go
if not exists (select * from sysobjects where name='PagosCuentasPagar' and xtype='U')
	BEGIN
		CREATE TABLE PagosCuentasPagar (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_cuentaPagar int,
		id_tipoPago int,
		monto_rd decimal (18,2),
		monto_usd decimal (18,2),
		fecha date,
		nota varchar(100),
		balance_rd decimal (18,2),
		balance_usd decimal (18,2)
		);
		
	END
Go

Drop table Seguros
go
if not exists (select * from sysobjects where name='Seguros' and xtype='U')
	BEGIN
		CREATE TABLE Seguros (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		nombre varchar(100),
		telefono varchar(30),
		estado bit
		);
		
	END
Go
Drop Table ImagenesTraspasos
if not exists (select * from sysobjects where name='ImagenesTraspasos' and xtype='U')
	BEGIN
		CREATE TABLE ImagenesTraspasos (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_factura int,
		id_vehiculo int,
		img varbinary(MAX)
		);
	END

Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertar_imagenes_traspaso' AND type = 'P')
DROP PROCEDURE insertar_imagenes_traspaso
GO
create procedure insertar_imagenes_traspaso
@img varbinary(max), @mensaje int output
as
set @mensaje = 0;
declare @idfactura int = (select MAX(id) from facturas)
declare @idVehiculo int = (select idVehiculo from facturas where id = @idfactura)
begin
	insert into ImagenesTraspasos(id_vehiculo,id_factura,img)
	Values (@idVehiculo,@idfactura, @img)
	set @mensaje = 1;
	
end
GO

Drop Table SeguroVehiculo
if not exists (select * from sysobjects where name='SeguroVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE SeguroVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_seguro int,
		duracion_dias int
		);
	END

Go


IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_tipos_pagos_sin_vehiculo' AND type = 'P')
	DROP PROCEDURE obtener_tipos_pagos_sin_vehiculo
	GO
	create procedure obtener_tipos_pagos_sin_vehiculo
	
	as
	
	begin
		select id as ID, formaPago as TIPOPAGO from TiposPago
		where id != 2
		 
	end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertarFormaTransaccionesFacturacion' AND type = 'P')
	DROP PROCEDURE insertarFormaTransaccionesFacturacion
	GO
	create procedure insertarFormaTransaccionesFacturacion
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output
	as
	declare @idFactura int = (select MAX(id) from facturas)
	set @mensaje = 0;
	begin
		insert into FormaVentaVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		declare @idCliente int= (Select id_cliente from facturas where id = @idFactura)
		
		if @idTipoPago = 3
			begin
				 insert into CuentasCobrar (id_factura, id_cliente, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idCliente, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)
			end

		if @idTipoPago = 1
			begin
				 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento,id_transaccion)
				 values (@idVehiculo, 2, @montoRD, @montoUSD, @fecha, 'Factura', @idFactura, @idTransaccion)
			end
		
		set @mensaje = 1;
		 
	end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertarFormaTransaccionesCompras' AND type = 'P')
	DROP PROCEDURE insertarFormaTransaccionesCompras
	GO
	create procedure insertarFormaTransaccionesCompras
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output
	as
	declare @idFactura int = 0
	set @mensaje = 0;
	set @idVehiculo = (select MAX(id) from Vehiculos)
	begin
		insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		declare @idSuplidor int = (select id_suplidor from Vehiculos where id = (select MAX(id) from Vehiculos))
		
		if @idTipoPago = 3 
			begin
				 insert into CuentasPagar (id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)
			end

		--if @idTipoPago = 1
		--	begin
		--		 insert into DetallesEfectivoGeneral(idVehiculo, tipoCuenta, montoRD, montoUSD, fecha, documento, numeroDocumento,id_transaccion)
		--		 values (@idVehiculo, 2, @montoRD, @montoRD, @fecha, 'Factura', @idFactura, @idTransaccion)
		--	end
		
		set @mensaje = 1;
		 
	end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertarFormaGastos' AND type = 'P')
	DROP PROCEDURE insertarFormaGastos
	GO
	create procedure insertarFormaGastos
	@idVehiculo int, @idTransaccion int, @idTipoPago int, @montoRD float, @montoUSD float,
	@nota varchar(100), @fecha date, @mensaje int output, @idSuplidor int
	as
	declare @idFactura int = 0
	set @mensaje = 0;
	begin
		insert into FormaCompraVehiculo (id_vehiculo, id_transaccion, id_tipo_pago, id_factura, monto_rd, monto_usd, nota, fecha)
		VALUES (@idVehiculo, @idTransaccion, @idTipoPago, @idFactura, @montoRD, @montoUSD, @nota, @fecha)
		
		
		
		
		if @idTipoPago = 3 
			begin
				 insert into CuentasPagar (id_factura, id_vendedor, id_transaccion, monto_rd, monto_usd,
				  balance_rd, balance_usd, fecha, id_vehiculo)
				  VALUES(@idFactura, @idSuplidor, @idTransaccion, @montoRD, @montoUSD, @montoRD, @montoUSD,
				  @fecha, @idVehiculo)

				  if @idTransaccion = 5 or @idTransaccion = 6 or @idTransaccion = 7
					begin
						update CuentasPagar set id_gasto = ((select IsNull(MAX(id), 0) from GastoVehiculo) + 1)
						where id = (select Max(id) from CuentasPagar)
					end
			end

		
		set @mensaje = 1;
		 
	end
Go

Drop Table PreciosSeguroVehiculo
if not exists (select * from sysobjects where name='PreciosSeguroVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE PreciosSeguroVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		precioRD decimal(18,2),
		precioUSD decimal(18,2)
		);
	END

Go

Drop Table PreciosTraspasoVehiculo
if not exists (select * from sysobjects where name='PreciosTraspasoVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE PreciosTraspasoVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		precioRD decimal(18,2),
		precioUSD decimal(18,2)
		);
	END

Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_detalle_traspaso_vehiculo' AND type = 'P')
	DROP PROCEDURE reporte_detalle_traspaso_vehiculo
	GO
create procedure reporte_detalle_traspaso_vehiculo
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 3
	end
	
end
go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_factura_traspaso_precio' AND type = 'P')
	DROP PROCEDURE reporte_factura_traspaso_precio
	GO
create procedure reporte_factura_traspaso_precio
@idVehiculo int
as

begin
	
	begin
		
		select precioRD as PRECIORD, precioUSD as PRECIOUSD
		from PreciosTraspasoVehiculo 
		where id_vehiculo = @idVehiculo
		
	end
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_factura_seguro_precio' AND type = 'P')
	DROP PROCEDURE reporte_factura_seguro_precio
	GO
create procedure reporte_factura_seguro_precio
@idVehiculo int
as

begin
	
	begin
		
		select S.nombre as SEGURO, PS.precioRD as PRECIORD, PS.precioUSD as PRECIOUSD
		from PreciosSeguroVehiculo PS join SeguroVehiculo SV on SV.id_vehiculo = PS.id_vehiculo
		join Seguros S on S.id = SV.id_seguro
		where PS.id_vehiculo = @idVehiculo
		Group by S.nombre, PS.precioRD , PS.precioUSD
		
	end
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_detalle_seguro_vehiculo' AND type = 'P')
	DROP PROCEDURE reporte_detalle_seguro_vehiculo
	GO
create procedure reporte_detalle_seguro_vehiculo
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from  FormaVentaVehiculo P join Vehiculos V on V.id = P.id_vehiculo join TiposPago TP on TP.id = P.id_tipo_pago
		where P.id_vehiculo = @idVehiculo and P.id_transaccion = 4
	end
	
end
Go
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_tipos_transacciones_cp' AND type = 'P')
	DROP PROCEDURE obtener_tipos_transacciones_cp
	GO
	create procedure obtener_tipos_transacciones_cp
	
	as
	
	begin
		select id as ID, transaccion as TRANSACCION from TipoTransaccion
		where id != 1 and id != 3
		 
	end
Go
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_detalle_traspaso' AND type = 'P')
	DROP PROCEDURE reporte_detalle_traspaso
	GO
create procedure reporte_detalle_traspaso
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 3	
	end
	
end

Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_detalle_seguro' AND type = 'P')
	DROP PROCEDURE reporte_detalle_seguro
	GO
create procedure reporte_detalle_seguro
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select P.monto_usd as PAGO, format(P.fecha,'dd/MM/yyyy') as FECHAPAGO, P.monto_rd as PAGORD,
		P.nota as DETALLEPAGO, TP.formaPago as TIPOPAGO
		from Vehiculos V join FormaVentaVehiculo P on V.id = P.id_vehiculo left join TiposPago TP on TP.id = P.id_tipo_pago
		where V.id = @idVehiculo and P.id_transaccion = 4	
	end
	
end

Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_recibo_de_cobro_traspaso' AND type = 'P')
	DROP PROCEDURE reporte_recibo_de_cobro_traspaso
	GO

create procedure [dbo].[reporte_recibo_de_cobro_traspaso]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
		end
	
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_recibo_de_cobro_seguro' AND type = 'P')
	DROP PROCEDURE reporte_recibo_de_cobro_seguro
	GO

create procedure [dbo].[reporte_recibo_de_cobro_seguro]
@idCC int, @tipoRecibo varchar(50), @numeroRecibo int
as

begin 
    if @tipoRecibo = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = (SELECT MAX(id) From PagosCuentasCobrar) and CC.id = @idCC
			

		end
	else
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, pcc.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, CC.balance_rd  as PENDIENTERD, CC.balance_usd as PENDIENTEUSD
			from 
			PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
	
			where PCC.id = @numeroRecibo and CC.id = @idCC
		end
	
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_obtener_detalle_cobros_traspaso' AND type = 'P')
	DROP PROCEDURE reporte_obtener_detalle_cobros_traspaso
	GO

create procedure [dbo].[reporte_obtener_detalle_cobros_traspaso]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_obtener_detalle_cobros_seguro' AND type = 'P')
	DROP PROCEDURE reporte_obtener_detalle_cobros_seguro
	GO

create procedure [dbo].[reporte_obtener_detalle_cobros_seguro]
@idCC int, @tipoReporte varchar(50), @numeroRecibo int
as

begin 
	if @tipoReporte = 'Recibo'
		begin
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
		end
	else
		begin
			
			select PCC.id as NUMERORECIBO, PCC.monto_rd as MONTORD, PCC.monto_usd as MONTOUSD, PCC.fecha as FECHACOBRO,
			TP.formaPago as FORMAPAGO, PCC.balance_rd as PENDIENTERD, PCC.balance_usd as PENDIENTEUSD
			from PagosCuentasCobrar PCC join TiposPago TP on Tp.id = PCC.id_tipoPago
			join CuentasCobrar CC on CC.id = PCC.id_cuentaCobrar
			where PCC.id_cuentaCobrar = @idCC
			and  PCC.id <= @numeroRecibo
		end
	
	
end
Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_precio_total_traspaso' AND type = 'P')
	DROP PROCEDURE reporte_precio_total_traspaso
	GO
create procedure reporte_precio_total_traspaso
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select precioRD as PRECIOSEGURORD, precioUSD as PRECIOSEGUROUSD from PreciosTraspasoVehiculo
		where id_vehiculo = @idVehiculo
	end
	
end

Go

IF EXISTS (SELECT name FROM sysobjects WHERE name = 'reporte_precio_total_seguro' AND type = 'P')
	DROP PROCEDURE reporte_precio_total_seguro
	GO
create procedure reporte_precio_total_seguro
@idVehiculo int
as
-- PAGOS VENTA
begin
	
	begin
		
		select Distinct S.nombre, PS.precioRD as PRECIOSEGURORD, PS.precioUSD as PRECIOSEGUROUSD from 
		PreciosSeguroVehiculo PS join SeguroVehiculo SV on SV.id_vehiculo = PS.id_vehiculo join Seguros S on S.id = SV.id_seguro
		where PS.id_vehiculo = @idVehiculo
	end
	
end

Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'registrar_seguro' AND type = 'P')
	DROP PROCEDURE registrar_seguro
	GO

	create procedure registrar_seguro
	@nombre varchar(100),@telefono varchar(50) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0;
	begin
		insert into Seguros (nombre, telefono, estado)
		Values (@nombre,@telefono ,@estado)
		set @mensaje = 1;
	
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_todos_seguros' AND type = 'P')
	DROP PROCEDURE obtener_todos_seguros
	GO
	create procedure obtener_todos_seguros
	as
	
	begin
		select id as ID, nombre as NOMBRE,telefono as TELEFONO ,estado as ESTADO from Seguros 
	end
	Go

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'actualizar_seguro' AND type = 'P')
	DROP PROCEDURE actualizar_seguro
	GO

	create procedure actualizar_seguro
	@idSeguro int, @nombre varchar(100),@telefono varchar(50) ,@estado bit, @mensaje int output
	as
	set @mensaje = 0
	begin
		Update Seguros set nombre = @nombre,telefono = @telefono ,estado = @estado where id = @idSeguro
		set @mensaje = 1
	end
	GO

	IF EXISTS (SELECT name FROM sysobjects WHERE name = 'obtener_seguros_activos' AND type = 'P')
	DROP PROCEDURE obtener_seguros_activos
	GO

	create procedure obtener_seguros_activos
	as
	
	begin
		select id as ID, nombre as SEGURO, estado as ESTADO from Seguros  where estado = 1
	end
	Go

Drop table TiposGastos
go
if not exists (select * from sysobjects where name='TiposGastos' and xtype='U')
	BEGIN
		CREATE TABLE TiposGastos (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		gasto varchar(100)
		);
		insert into TiposGastos (gasto)
		Values ('REPARACION'),('OTROS')
	END
Go



Drop table GastoVehiculo
go
if not exists (select * from sysobjects where name='GastoVehiculo' and xtype='U')
	BEGIN
		CREATE TABLE GastoVehiculo (
		id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
		id_vehiculo int,
		id_gasto int,
		id_proveedor int,
		id_transaccion int,
		monto_rd decimal(18,2),
		monto_usd decimal(18,2),
		fecha date
		);
		
	END

Go
IF EXISTS (SELECT name FROM sysobjects WHERE name = 'insertar_gasto_vehiculo' AND type = 'P')
	DROP PROCEDURE insertar_gasto_vehiculo
	GO

	create procedure  insertar_gasto_vehiculo
	@idGasto int, @idProveedor int, @idVehiculo int, @montoRD float, @montoUSD float, @fecha date,
	@mensaje int output, @idTransaccion int
	as
	set @mensaje = 0;
	begin
		insert into GastoVehiculo(id_gasto, id_proveedor, id_vehiculo, monto_rd, monto_usd, fecha, id_transaccion)
		VALUES (@idGasto, @idProveedor, @idVehiculo, @montoRD, @montoUSD, @fecha, @idTransaccion)
		
		update Vehiculos set total_invertido_rd = total_invertido_rd + @montoRD, total_invertido_usd = total_invertido_usd + @montoUSD
		where id = @idVehiculo

		set @mensaje = 1;
	end

	GO

	

