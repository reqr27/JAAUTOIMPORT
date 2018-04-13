--**************************************************UPDATE***********************************************************************
GO
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
ALTER procedure obtener_todos_clientes
as
begin

	select id as ID, cliente as CLIENTE, rnc_cedula as 'RNC/CEDULA',direccion as DIRECCION ,telefono as 'TEL.', estado as HABILITADO
	from Clientes
	
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
create procedure [dbo].[insertar_imagenes_clientes] 
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