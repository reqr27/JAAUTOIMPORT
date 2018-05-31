
insert into facturas (idVehiculo, id_cliente, id_transaccion, fecha)
Values (1,2,3, '2018-04-25'),
(1,2,4, '2018-04-25'),
(1019,29,3, '2018-05-08'),
(1019,29,4, '2018-05-08'),
(11,35,3, '2018-05-14'),
(11,35,4, '2018-05-14'),
(1006,33,3, '2018-05-18'),
(1006,33,4, '2018-05-18'),
(1008,34,3, '2018-05-12'),
(1008,34,4, '2018-05-12'),
(1013,36,3, '2018-05-24'),
(1013,36,4, '2018-05-24')
go

ALTER TABLE facturas
ADD id_transaccion int;

go

--update facturas set id_transaccion = 1 

go

ALTER procedure [dbo].[insertar_factura]
@idVehiculo int, @mensaje int output, @idCliente int,
@fecha date, @idTransaccion int
as
set @mensaje = 0
begin
	insert into facturas(idVehiculo, id_cliente, fecha, id_transaccion) VALUES (@idVehiculo, @idCliente, @fecha, @idTransaccion)
	set @mensaje = 1
end

go

create procedure obtener_vehiculos_vendidos_sin_traspaso
as

begin
	
	select Top 1 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, 
	V.id as ID
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join facturas fa on fa.idVehiculo = v.id 
	where v.vendido = 1 and not exists(select fac.id_transaccion from facturas fac where fac.idVehiculo = V.id and fac.id_transaccion = 3)
	

end

go
create procedure obtener_vehiculos_vendidos_sin_seguro
as

begin
	
	select Top 1 
	CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO, 
	V.id as ID
	from Vehiculos V 
	join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
	join facturas fa on fa.idVehiculo = v.id 
	where v.vendido = 1 and not exists(select fac.id_transaccion from facturas fac where fac.idVehiculo = V.id and fac.id_transaccion = 4)

end

GO

create procedure obtener_cliente_vehiculo_vendido
@idVehiculo int
as

begin
	
	select  C.cliente as CLIENTE, C.id as ID
	from Clientes C join Vehiculos V on V.id_cliente = C.id
	where V.id = @idVehiculo

end

GO


ALTER procedure [dbo].[reporte_factura_traspaso_precio]
@idVehiculo int
as

begin
	
	begin
		
		select PT.precioRD as PRECIORD, PT.precioUSD as PRECIOUSD,
		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
		C.cliente as CLIENTE, C.rnc_cedula as CEDULA, C.direccion as DIRECCION, C.telefono as TELEFONO, fac.id as NUMEROFACTURA,
		fac.fecha as FECHA
		from facturas fac join PreciosTraspasoVehiculo PT on PT.id_vehiculo = fac.idVehiculo join Vehiculos V on PT.id_vehiculo = V.id
		join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
		join Clientes C on fac.id_cliente = C.id
		where fac.idVehiculo = 1022 and fac.id_transaccion = 3
		
	end
	
end

go

ALTER procedure [dbo].[reporte_factura_seguro_precio]
@idVehiculo int
as

begin
	
	begin
		
		select S.nombre as SEGURO, PS.precioRD as PRECIORD, PS.precioUSD as PRECIOUSD, duracion_dias as DURACION,
		CONVERT(varchar(200),(F.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
		C.cliente as CLIENTE, C.rnc_cedula as CEDULA, C.direccion as DIRECCION, C.telefono as TELEFONO, fac.id as NUMEROFACTURA,
		fac.fecha as FECHA
		from facturas fac join PreciosSeguroVehiculo PS on PS.id_vehiculo = fac.idVehiculo join SeguroVehiculo SV on SV.id_vehiculo = PS.id_vehiculo
		join Seguros S on S.id = SV.id_seguro join Vehiculos V on PS.id_vehiculo = V.id
		join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id
		join Clientes C on fac.id_cliente = C.id
		where fac.idVehiculo = @idVehiculo and fac.id_transaccion = 4
		

		
		
		
	end
	
end

go

ALTER procedure [dbo].[reporte_factura_obtener_monto_pendiente]
@idVehiculo int, @idTransaccion int
as

begin
	
	begin
		
		select ISNULL(sum(monto_rd), 0) as PENDIENTERD, ISNULL(sum(monto_usd), 0) as PENDIENTEUSD 
		from FormaVentaVehiculo
		where id_vehiculo = @idVehiculo and id_tipo_pago = 3 and id_transaccion = @idTransaccion
				
					
	
	end
	
end

go

ALTER procedure [dbo].[obtener_facturas]
@desde date, @hasta date
as

begin
	
	select F.id as '# Factura', format(F.fecha,'dd/MM/yyyy') as FECHAVENDIDO, TP.transaccion as 'TIPO FACTURA',
	CONVERT(varchar(200),(Fab.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	V.precioVentaRD as PRECIORD, V.precioVentaUSD  as PRECIOUSD,
	C.cliente as CLIENTE, F.idVehiculo as ID
	from facturas F join Vehiculos V on V.id = F.idVehiculo join Fabricantes Fab on Fab.id = V.fabricante_id 
	join Modelos M on M.id = V.modelo_id join Clientes C on F.id_cliente = C.id join TipoTransaccion TP on TP.id = F.id_transaccion
	where V.vendido = 1 and F.id_transaccion = 1
	and format(F.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')

	union

	select F.id as '# Factura', format(F.fecha,'dd/MM/yyyy') as FECHAVENDIDO, TP.transaccion as 'TIPO FACTURA',
	CONVERT(varchar(200),(Fab.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	PT.precioRD as PRECIORD, PT.precioUSD  as PRECIOUSD,
	C.cliente as CLIENTE, F.idVehiculo as ID
	from facturas F join Vehiculos V on V.id = F.idVehiculo join Fabricantes Fab on Fab.id = V.fabricante_id 
	join Modelos M on M.id = V.modelo_id join Clientes C on F.id_cliente = C.id join TipoTransaccion TP on TP.id = F.id_transaccion
	join PreciosTraspasoVehiculo PT on PT.id_vehiculo = F.idVehiculo
	where V.vendido = 1 and F.id_transaccion = 3
	and format(F.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')


	union

	
	select F.id as '# Factura', format(F.fecha,'dd/MM/yyyy') as FECHAVENDIDO, TP.transaccion as 'TIPO FACTURA',
	CONVERT(varchar(200),(Fab.fabricante + ' ' + M.modelo + ' ' + CONVERT(varchar(10), V.año) + ' ' + V.color)) as VEHICULO,
	Isnull(PS.precioRD, 0) as PRECIORD, isnull(PS.precioUSD, 0) as PRECIOUSD,
	C.cliente as CLIENTE, F.idVehiculo as ID
	from facturas F join Vehiculos V on V.id = F.idVehiculo join Fabricantes Fab on Fab.id = V.fabricante_id 
	join Modelos M on M.id = V.modelo_id left join PreciosSeguroVehiculo PS on PS.id_vehiculo = F.idVehiculo 
	join Clientes C on F.id_cliente = C.id join TipoTransaccion TP on TP.id = F.id_transaccion
	where V.vendido = 1 and F.id_transaccion = 4
	and format(F.fecha,'yyyy-MM-dd') between
	format (@desde, 'yyyy-MM-dd') and format (@hasta, 'yyyy-MM-dd')
	order by [# Factura] asc
end

go

create procedure [dbo].[insertar_seguro_vehiculo]
@idVehiculo int, @fecha date ,@mensaje int output, 
@idCliente int, @precioSeguroRd float, @precioSeguroUsd float,
@idSeguro int, @duracion int
as
set @mensaje = 0



begin
	
	insert into SeguroVehiculo (id_vehiculo, id_seguro, duracion_dias)
	Values (@idVehiculo, @idSeguro, @duracion)

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

Go

create procedure [dbo].[insertar_traspaso_vehiculo]
@idVehiculo int, @fecha date ,@mensaje int output, 
@idCliente int,
@precioTraspasoRd float, @precioTraspasoUsd float
as
set @mensaje = 0



begin
		
	insert into PreciosTraspasoVehiculo(id_vehiculo,precioRD, precioUSD )
	Values (@idVehiculo, @precioTraspasoRd, @precioTraspasoUsd)
	set @mensaje = 1
			
end

go

ALTER procedure [dbo].[vender_vehiculo]
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
			set @mensaje = 1	

		 end
				
				
end

go

ALTER Procedure [dbo].[borrar_venta_y_detalles_pagos]
@idVehiculo int, @idTransaccion int
as
--declare @idVehiculo int = 1;
begin
	
	if @idTransaccion = 1
		begin
			update Vehiculos set vendido = 0, fecha_vendido = null, id_cliente = null,
			precioVentaRD = null, precioVentaUSD = null
			where id = @idVehiculo
			
			
		end
	else if @idTransaccion = 3
		begin
			Delete from PreciosTraspasoVehiculo where id_vehiculo = @idVehiculo
			delete from ImagenesTraspasos where id_vehiculo = @idVehiculo
			
		end
	else 
		begin
			Delete from CuentasPagar where id_vehiculo = @idVehiculo and id_transaccion = @idTransaccion
			Delete from SeguroVehiculo where id_vehiculo = @idVehiculo
			Delete from PreciosSeguroVehiculo where id_vehiculo = @idVehiculo
		end
	
	delete from facturas where idVehiculo = @idVehiculo and id_transaccion = @idTransaccion
	delete from DetallesEfectivoGeneral where idVehiculo = @idVehiculo and id_transaccion = @idTransaccion
	Delete from FormaVentaVehiculo where id_vehiculo = @idVehiculo and id_transaccion = @idTransaccion
	Delete from CuentasCobrar where id_vehiculo = @idVehiculo and id_transaccion = @idTransaccion

end

go

ALTER procedure [dbo].[reporte_factura_vehiculo]
@idVehiculo int
as

begin
	
	begin
		
		select top 1 V.id as ID, F.fabricante as FABRICANTE, M.modelo as MODELO, V.año as AÑO, V.total_invertido_usd as INVERTIDO,
		V.precioVentaRD as PRECIORD, V.precioVentaUSD as PRECIO,V.vin as VIN, 
		format(V.fecha_importe,'dd/MM/yyyy') as IMPORTADO, V.nota as COMENTARIO, C.cliente as CLIENTE, C.rnc_cedula as CEDULA,
		format(V.fecha_vendido,'dd/MM/yyyy') as FVENDIDO, V.pagado as PAGADO, P.nombre as PROPIETARIO, V.vendido as VENDIDO,
		V.terminado as TERMINADO, V.nota as DETALLES, V.color as COLOR, fac.id as FACTURA
		from Vehiculos V join Fabricantes F on V.fabricante_id = F.id join Modelos M on V.modelo_id = M.id 
		join facturas fac on V.id = fac.idVehiculo join Propietarios P on V.id_propietario = P.id 
		left join Clientes C on V.id_cliente = C.id
		where V.id = @idVehiculo
				
					
	
	end
	
end