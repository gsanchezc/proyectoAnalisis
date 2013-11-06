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

--*Tabla Nueva para los procedures--
---------------------------Procedure de almacenamiento para la tabla Estatus Alertas--------------------
---------------------------------------------------------------------------------------------------------

---------------Procedure que inserta datos en la tabla tbl_estatusAlertas-----------------------------
create procedure stp_insertarEstatusAlertas
(
	@id int, ----->Id perteneciente al idEstatusAlertas------
	@descripcion varchar (50) --->Descripcion del Estatus Alertas----
)

as
begin
		insert into db_soportic.dbo.tbl_estatusAlertas(descripcion) 
		values(@descripcion)
end

go


----------------------Procedure que modifica y actualiza los datos-----------------------------
create procedure stp_modificarEstatusAlertas
(
		@id int,
		@descripcion int
)

 as
 begin
	update db_soportic.dbo.tbl_estatusAlertas set descripcion = @descripcion
	where idEstatusAlertas = @id
 end

go

---------------------Procedure que trae/jala la informacion-------------------
create procedure stp_traeInfoEstatusAlertas
(
    @id int
)

 as
 begin
	select *
	from db_soportic.dbo.tbl_estatusAlertas where idEstatusAlertas = @id
 end

go

-----------Procedure que trae el Estatus de Alertas-----------------------
create procedure stp_traeEstatusAlertas
as
begin
	select idEstatusAlertas, descripcion 
	from tbl_estatusAlertas
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
	where idEstatusTickets = @id
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
	from db_soportic.dbo.tbl_estatusTickets where idEstatusTickets = @id
 end

go

-----------Procedure que trae el Estatus de Tickets-----------------------
create procedure stp_traeEstatusTickets
as
begin
	select idEstatusTickets, descripcion 
	from tbl_estatusTickets
end
go

----*Corregida esta tabla, con los datos ya actualizados con la base de datos
---------------------------Procedure de almacenamiento para la tabla Departamentos-------------
----------------------------------------------------------------------------------------------------------

----------------Procedure que inserta datos en la tabla tbl_Departamentos--------------------
create procedure stp_insertarDepartamentos
(
		@id int,  ---->Id que corresponde a idDepartamento----
		@descripcion varchar(50)-->Descripcion del Departamento---
)

as

begin
	insert into db_soportic.dbo.tbl_Departamentos(descripcion) 
	values(@descripcion)
end

go

------------------Procedure que modifica y actualiza datos en la tabla tbl_Departamentos----------
create procedure stp_modificarDepartamentos
(
		@id int,
		@descripcion varchar(50)
)

as
begin
	update db_soportic.dbo.tbl_Departamentos set descripcion = @descripcion
	where idDepartamento  = @id
end

go

---------------Procedure que trae/jala la informacion de la tabla tbl_Departamentos---------
create procedure stp_traeInfoDepartamentos
(
     @id int
)

as
begin
	select *
	from tbl_Departamentos where idDepartamento = @id
end

go

---------------Procedure que trae la Descripcion de Departamentos-----------------
create procedure stp_traeDepartamentos

as
begin
	select idDepartamento, descripcion 
	from tbl_Departamentos
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
	where idArchivoAdjunto  = @id
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
	from tbl_datosAdjuntos where idArchivoAdjunto  = @id
end

go

----------------Procedure que trae los datos Adjuntos de la tabla tbl_datosAdjuntos--------------
create procedure stp_traeDatosAdjuntos

as
begin
	select idArchivoAdjunto, archivo 
	from tbl_datosAdjuntos
end
go

---*Nueva Tabla
---------------------------Procedure de almacenamiento para la tabla tipoServicio--------------------
------------------------------------------------------------------------------------------------------

------------------Procedure que inserta datos en la tabla tbl_tipoServicio-------------------------
create procedure stp_insertarTipoServicio
(
		@id int, --->id que pertenece a idTipoServicio-----
		@descripcion varchar(50)--->Descripcion Tipo Servicio, de tipo Varchar-----
)

as
begin
	insert into tbl_tipoServicio(descripcion) 
	values(@descripcion)
end

go

-------------Procedure que modifica y actualiza los datos de la tabla tbl_tipoServicio-----------------
create procedure stp_modificarTipoServicio
(
	@id int,
	@descripcion varchar(50)
)

as
begin
	update tbl_tipoServicio set descripcion = @descripcion
	where idTipoServicio  = @id
end

go

--------------------Procedure que trae/jala la informacion dela tabla tbl_tipoServicio-------------
create procedure stp_traeInfoTipoServicio
(
    @id int
)

as
begin
	select *
	from tbl_tipoServicio where idTipoServicio  = @id
end

go

----------------Procedure que trae los datos de la tabla tbl_tipoServicio--------------
create procedure stp_traeTipoServicio

as
begin
	select idtipoServicio, descripcion
	from tbl_tipoServicio
end
go

---*Nueva Tabla
---------------------------Procedure de almacenamiento para la tabla tipoPrioridad--------------------
------------------------------------------------------------------------------------------------------

------------------Procedure que inserta datos en la tabla tbl_tipoPrioridad-------------------------
create procedure stp_insertarTipoServicio
(
		@id int, --->id que pertenece a idTipoPrioridad-----
		@descripcion varchar(50)--->Descripcion Tipo Prioridades, de tipo Varchar-----
)

as
begin
	insert into tbl_tipoPrioridades(descripcion) 
	values(@descripcion)
end

go

-------------Procedure que modifica y actualiza los datos de la tabla tbl_tipoPrioridades-----------------
create procedure stp_modificarTipoPrioridad
(
	@id int,
	@descripcion varchar(50)
)

as
begin
	update tbl_tipoPrioridades set descripcion = @descripcion
	where idPrioridad  = @id
end

go

--------------------Procedure que trae/jala la informacion dela tabla tbl_tipoPrioridades-------------
create procedure stp_traeInfoTipoPrioridad
(
    @id int
)

as
begin
	select *
	from tbl_tipoPrioridades where idPrioridad  = @id
end

go

----------------Procedure que trae los datos de la tabla tbl_tipoPrioridades--------------
create procedure stp_traeTipoPrioridad

as
begin
	select idPrioridad, descripcion
	from tbl_tipoPrioridades
end
go

---*Nueva Tabla
---------------------------Procedure de almacenamiento para la tabla tipoAlertas--------------------
------------------------------------------------------------------------------------------------------

------------------Procedure que inserta datos en la tabla tbl_tipoAlertas-------------------------
create procedure stp_insertarTipoServicio
(
		@id int, --->id que pertenece a idTipoAlerta-----
		@descripcion varchar(50)--->Descripcion Tipo Alertas, de tipo Varchar-----
)

as
begin
	insert into tbl_TipoAlertas(descripcion) 
	values(@descripcion)
end

go

-------------Procedure que modifica y actualiza los datos de la tabla tbl_tipoAlertas-----------------
create procedure stp_modificarTipoAlertas
(
	@id int,
	@descripcion varchar(50)
)

as
begin
	update tbl_TipoAlertas set descripcion = @descripcion
	where idTipoAlerta  = @id
end

go

--------------------Procedure que trae/jala la informacion dela tabla tbl_tipoAlertas-------------
create procedure stp_traeInfoTipoAlertas
(
    @id int
)

as
begin
	select *
	from tbl_TipoAlertas where idTipoAlerta  = @id
end

go

----------------Procedure que trae los datos de la tabla tbl_tipoAlertas--------------
create procedure stp_traeTipoAlertas

as
begin
	select idTipoAlerta, descripcion
	from tbl_TipoAlertas
end
go

