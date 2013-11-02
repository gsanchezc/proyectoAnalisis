
use db_soportic

go

--Procedimientos almacenados para la tabla estadoFactura------------------------------------
create procedure stp_insertaEstadoFactura
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_estatusFacturas(descripcion) values(@descripcion)
end

go

create procedure stp_modificarEstadosFactura
(
@id int,
@descripcion varchar(50)
)
as
begin
update tbl_estatusFacturas
set descripcion = @descripcion
where idEstatus = @id
end

go

create procedure stp_traeInfoEstadosFactura
(
@id int
)
as
begin
select *from tbl_estatusFacturas where idEstatus = @id
end

go

create procedure stp_traeListaEstadosFactura
as
begin
select idEstatus, descripcion from tbl_estatusFacturas
end

go
-----------------------------------------------------------------------------------------
---Procedimientos almacenados para la tabla Descripcion Roles----------------------------
create procedure stp_insertarDescripcionRol
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_descripcionRoles(descripcion) values(@descripcion)
end

go

create procedure stp_modificarDescripcionRol
(
@id int,
@descripcion varchar(50)
)
as
begin
update tbl_descripcionRoles
set descripcion = @descripcion
where idRol = @id
end

go

create procedure stp_traeInfoDescripcionRol
(
@id int
)
as
begin
select *from tbl_descripcionRoles where idRol = @id
end

go

create procedure stp_traeDescripcionRol
as
begin
select idRol, descripcion from tbl_descripcionRoles
end
go
------------------------------------------------------------------------------------------
-----Procedimientos almacenados para la tabla tipo Puestos---------------------------

create procedure stp_insertarTipoPuestos
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_tipoPuestos(descripcion) values(@descripcion)
end

go

create procedure stp_modificarTipoPuestos
(
@id int,
@descripcion varchar(50)
)
as
begin
update tbl_tipoPuestos
set descripcion = @descripcion
where idPuesto = @id
end

go

create procedure stp_traeInfoTipoPuestos
(
@id int
)
as
begin
select *from tbl_tipoPuestos where idPuesto = @id
end

go

create procedure stp_traeTipoPuestos
as
begin
select idPuesto, descripcion from tbl_tipoPuestos
end
GO

----------------------------------------------------------------------------------------

create procedure stp_insertaTipoIdentificacion
(
		@id int, ---->este id pertenece al idTipoIdentificacion---- 
		@descripcion varchar(50)---> descripcion del tipo de identificacion---
)
as

begin

	insert into db_soportic.dbo.tbl_tipoIdentificaciones(descripcion) 
	values(@descripcion)
	
end

go


create procedure stp_modificarTipoIdentificacion
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	update db_soportic.dbo.tbl_tipoIdentificaciones set descripcion = @descripcion
    where idTipoIdentificacion = @id
end

go

---------Procedure que trae/jala la informacion de la tabla tbl_tipoIdentificacion--------
create procedure stp_traeInfoTipoIdentificacion
(
    @id int
)	
	
as
begin
	select *
	from tbl_tipoIdentificaciones where idTipoIdentificacion = @id
end

go



----------Procedure de borrado---------
create procedure stp_borrarTipoIdentificacion
(
   @id int
)

as
begin
delete db_soportic.dbo.tbl_tipoIdentificaciones  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
where  idTipoIdentificacion = @id
end

go


---------------------------Procedure de almacenamiento para la tabla tipoClientesProveedores-------------
---------------------------------------------------------------------------------------------------------


--------------------Procedure que inserta datos en la tabla tbl_tipoClienteProveedor------------------
create procedure stp_insertarTipoClienteProveedor
(
		@id int,  ---->Id correspondiente al idTipoClienteProveedor------
		@descripcion varchar(50) ---->Descripcion del Tipo Cliente Proveedor-----
)
as
 begin
		insert into db_soportic.dbo.tbl_tipoClientesProveedores(descripcion) 
		values(@descripcion)
 end

go

------------Procedure que modifica y actualiza datos en la tabla tbl_tipoClienteProveedor--------
create procedure stp_modificarTipoClienteProveedor
(
		@id int,
		@descripcion varchar(50)
)
as
begin
	update db_soportic.dbo.tbl_tipoClientesProveedores set descripcion = @descripcion
	where idTipoClienteProveedor = @id
end

go

----------------Procedure que trae/jala la informacion de la tabla tbl_tipoClienteProveedor------------
create procedure stp_traeInfoTipoClienteProveedor
(
    @id int
)

as
begin
	select *
	from tbl_tipoClientesProveedores where idTipoClienteProveedor = @id
end
go

----------Procedure que sólo trae datos de la tabla tbl_tipoClienteProveedor---------------
create procedure stp_traeTipoClienteProveedor

as
begin
		select idTipoClienteProveedor, descripcion 
		from db_soportic.dbo.tbl_tipoClientesProveedores
end
go

-------------Procedure que trae la lista de clientes proveedores de la tabla tbl_tipoClientesProveedores-------------
create procedure stp_traeListaTipoClienteProveedor

as
begin
		select idTipoClienteProveedor, descripcion 
		from tbl_tipoClientesProveedores
end
go


---------------------------Procedure de almacenamiento para la tabla estatusTickets-------------------
------------------------------------------------------------------------------------------------------

---------------Procedure que inserta datos en la tabla tbl_estatusTickets-----------------------------
create procedure stp_insertarEstatusTickets
(
	@id int, ----->Id perteneciente al idEstatus------
	@descripcion varchar (50) --->Descripcion del Estatus Ticket----
)

as
begin
		insert into db_soportic.dbo.tbl_estatusTickets(descripcion) 
		values(@descripcion)
end

go


----------------------Procedure que modifica y actualiza los datos-----------------------------
create procedure stp_modificarEstatusTickets
(
		@id int,
		@descripcion int
)

 as
 begin
	update db_soportic.dbo.tbl_estatusTickets set descripcion = @descripcion
	where idEstatus = @id
 end

go

---------------------Procedure que trae/jala la informacion-------------------
create procedure stp_traeInfoEstatusTickets
(
    @id int
)

 as
 begin
	select *
	from db_soportic.dbo.tbl_estatusTickets where idEstatus = @id
 end

go

-----------Procedure que trae el Estatus de Tickets-----------------------
create procedure stp_traeEstatusTickets
as
begin
	select idEstatus, descripcion 
	from tbl_estatusTickets
end
go


---------------------------Procedure de almacenamiento para la tabla descripcionDepartamentos-------------
----------------------------------------------------------------------------------------------------------

----------------Procedure que inserta datos en la tabla tbl_descripcionDepartamentos--------------------
create procedure stp_insertarDescripcionDepartamentos
(
		@id int,  ---->Id que corresponde a idDepartamento----
		@descripcion varchar(50)-->Descripcion del Departamento---
)

as

begin
	insert into db_soportic.dbo.tbl_descripcionDepartamentos(descripcion) 
	values(@descripcion)
end

go

------------------Procedure que modifica y actualiza datos en la tabla tbl_descripionDepartamentos----------
create procedure stp_modificarDescripcionDepartamentos
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	update db_soportic.dbo.tbl_descripcionDepartamentos set descripcion = @descripcion
	where idDepartamento  = @id
end

go

---------------Procedure que trae/jala la informacion de la tabla tbl_descripcionDepartamentos---------
create procedure stp_traeInfoDescripcionDepartamentos
(
     @id int
)

as
begin
	select *
	from tbl_descripcionDepartamentos where idDepartamento = @id
end

go

---------------Procedure que trae la Descripcion de Departamentos-----------------
create procedure stp_traeDescripcionDepartamentos

as
begin
	select idDepartamento, descripcion 
	from tbl_descripcionDepartamentos
end

go
---------------------------Procedure de almacenamiento para la tabla datosAdjuntos--------------------
------------------------------------------------------------------------------------------------------

------------------Procedure que inserta datos en la tabla tbl_datosAdjuntos-------------------------
create procedure stp_insertarDatosAdjuntos
(
		@id int, --->id que pertenece a idArchivo-----
		@archivo varbinary(max)--->Archivo Adjunto en una variable varbinary-----
)

as
begin
	insert into tbl_datosAdjuntos(archivo) 
	values(@archivo)
end

go

-------------Procedure que modifica y actualiza los datos de la tabla tbl_datosAdjuntos-----------------
create procedure stp_modificarDatosAdjuntos
(
	@id int,
	@archivo varbinary(max)
)

as
begin
	update tbl_datosAdjuntos set archivo = @archivo
	where idArchivo  = @id
end

go

--------------------Procedure que trae/jala la informacion dela tabla tbl_datosAdjuntos-------------
create procedure stp_traeInfoDatosAdjuntos
(
    @id int
)

as
begin
	select *
	from tbl_datosAdjuntos where idArchivo  = @id
end

go

----------------Procedure que trae los datos Adjuntos de la tabla tbl_datosAdjuntos--------------
create procedure stp_traeDatosAdjuntos

as
begin
	select idArchivo, archivo 
	from tbl_datosAdjuntos
end
go

