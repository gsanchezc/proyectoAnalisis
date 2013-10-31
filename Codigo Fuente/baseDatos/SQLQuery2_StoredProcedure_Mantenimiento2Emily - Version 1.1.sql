use db_soportic

go

---------------------------Procedure de almacenamiento para la tabla tipoIdentificaciones-------------
------------------------------------------------------------------------------------------------------

--------------------Procedure que inserta datos en la tabla tbl_tipoIdentificaciones------------------
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

--------Procedure que actualiza y modifica los datos de la tabla tbl_tipoIdentificacion-----
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

---------------Procedure de borrado----------------------
create procedure stp_borrarTipoIdentificacion
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	delete tbl_tipoClientesProveedores  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
	where idTipoClienteProveedor = @id
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

---------------Procedure de borrado----------------------
create procedure stp_borrarEstatusTickets
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	delete db_soportic.dbo.tbl_estatusTickets  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
	where idEstatus = @id
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

----------------Procedure de borrado------------------------------
create procedure stp_borrarDescripcionDepartamentos
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	delete tbl_descripcionDepartamentos  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
	where  idDepartamento  = @id
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

----------------Procedure de borrado---------------------
create procedure stp_borrarDatosAdjuntos
(
	@id int,
	@archivo varbinary(max)
)
as
begin
	delete tbl_datosAdjuntos  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
	where  idArchivo = @id
end
go