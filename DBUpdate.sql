--**************************************************UPDATE***********************************************************************
GO
if Not Exists(select * from sys.columns where Name = N'agregar_paises'  and Object_ID = Object_ID(N'Usuarios'))
	begin
		alter Table Usuarios 
		Add agregar_paises bit NOT NULL DEFAULT 1,
		agregar_ciudades bit NOT NULL DEFAULT 1,
		agregar_colores bit NOT NULL DEFAULT 1,
		agregar_ubicaciones bit NOT NULL DEFAULT 1,
		agregar_suplidores bit NOT NULL DEFAULT 1
		
	end

GO

ALTER procedure registrar_usuarios
@usuario varchar(50), @nombre varchar(50), @clave varchar(50), @tasaDolar bit, @crearUsuarios bit,
@fabricantesModelos bit, @piezasRepuestos bit, @crearTaller bit, @crearPropietarios bit, @crearClientes bit, 
@crearGastos bit, @importarVehiculos bit, @compras bit, @cambiarEstadosVehiculos bit, @agregarGastos bit,
@agregarPiezas bit, @facturacion bit, @reportes bit, @estado bit, @mensaje int output, @modificarVehiculo bit, 
@cuentasPagar bit, @cuentasCobrar bit, @actualizarTasaDiario bit, @crearPais bit, @crearCiudad bit, @crearSuplidor bit,
@crearColor bit, @crearUbicacion bit
as
set @mensaje = 0

begin

	if not exists(select * from Usuarios where usuario = @usuario)
		begin
			insert into Usuarios(usuario, clave, nombreApellido, tasaDolar, crearUsuarios, fabricantesModelos,
			 piezasRepuestos, crearTaller, crearPropietarios, crearClientes, crearGastos, importarVehiculo, 
			 compras, cambiarEstadosVehiculo, agreagarGastos, agregarPiezas, facturacion, reportes, estadoUsuario,
			 modificarVehiculo, cuentasCobrar, cuentasPagar, actualizarDiarioTasa, agregar_paises, agregar_ciudades,
			 agregar_suplidores, agregar_colores, agregar_ubicaciones) 
			VALUES(@usuario, @clave, @nombre, @tasaDolar, @crearUsuarios, @fabricantesModelos, @piezasRepuestos,
			@crearTaller, @crearPropietarios, @crearClientes, @crearGastos, @importarVehiculos, @compras,
			@cambiarEstadosVehiculos, @agregarGastos, @agregarPiezas, @facturacion, @reportes, @estado, @modificarVehiculo,
			@cuentasCobrar, @cuentasPagar, @actualizarTasaDiario, @crearPais, @crearCiudad, @crearSuplidor, @crearColor,
			@crearUbicacion) 
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
@crearColor bit, @crearUbicacion bit
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
			agregar_colores = @crearColor, agregar_ubicaciones = @crearUbicacion
			
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
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES'
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
	agregar_ubicaciones as 'AGREGAR UBICACIONES', agregar_suplidores as 'AGREGAR SUPLIDORES'
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