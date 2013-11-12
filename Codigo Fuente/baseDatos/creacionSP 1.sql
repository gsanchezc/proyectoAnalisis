
use db_soportic

go

-----------------Procedures de los Mantenimientos-------------------------------------------

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

-------------Procedures de las demás tablas--------------------------------------------

---------------------------Procedure de almacenamiento para la tabla Salarios-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaSalarios
(
    @id int,
	@idEmpleado int,
	@monto decimal(18,2)
	
)
as
begin
insert into  db_soportic.dbo.tbl_salarios(idEmpleado,monto) 
values(@idEmpleado,@monto)
end

go

create procedure stp_modificarSalarios
(
    @id int,
	@idEmpleado int,
	@monto decimal (18,2)
)
as
begin
update  db_soportic.dbo.tbl_salarios
set monto = @monto
where idSalario = @id
end

go

create procedure stp_traeInfoSalarios
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_salarios where idSalario = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Empresas Clientes-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaEmpresasClientes
(
    @id int,
	@nombre varchar(50),
	@idTipoIdentificacion int,
	@identificacion varchar(15) ,
	@telefonoEmpresa varchar(15)
	
)
as
begin
insert into db_soportic.dbo.tbl_empresasClientes(nombre,idTipoIdentificacion,identificacion,telefonoEmpresa) 
values(@nombre,@idTipoIdentificacion,@identificacion,@telefonoEmpresa)
end

go

create procedure stp_modificarEmpresasClientes
(
    @id int,
	@nombre varchar(50),
	@idTipoIdentificacion int,
	@identificacion varchar(15) ,
	@telefonoEmpresa varchar(15)
)
as
begin
update  db_soportic.dbo.tbl_empresasClientes
set nombre = @nombre
where idEmpresaCliente = @id
end

go

create procedure stp_traeInfoEmpresasClientes 
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_empresasClientes where idEmpresaCliente = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Clientes Usuario Final-----------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaClienteUsuarioFinal
(
    @id int,
	@idUsuarioSistema int,
	@nombre varchar (50),
	@apellidos varchar (50),
	@idTipoIdentificacion int,
	@identificacion varchar(15) ,
	@telefonoEmpresa varchar(15),
	@idEmpresaCliente int
	
)
as
begin
insert into db_soportic.dbo.tbl_clientesUsuarioFinal(idUsuarioSistema,nombre,apellidos,idTipoIdentificacion,identificacion,telefonoEmpresa,idEmpresaCliente) 
values(@idUsuarioSistema,@nombre,@apellidos,@idTipoIdentificacion,
       @identificacion,@telefonoEmpresa,@idEmpresaCliente)
end

go

create procedure stp_modificarClienteUsuarioFinal
(
    @id int,
	@idUsuarioSistema int,
	@nombre varchar (50),
	@apellidos varchar (50),
	@idTipoIdentificacion int,
	@identificacion varchar(15) ,
	@telefonoEmpresa varchar(15),
	@idEmpresaCliente int
)
as
begin
update  db_soportic.dbo.tbl_clientesUsuarioFinal
set nombre = @nombre
where idClienteUsuarioFinal = @id
end

go

create procedure stp_traeInfoClientesUsuarioFinal 
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_clientesUsuarioFinal where idClienteUsuarioFinal = @id
end

go


---------------------------Procedure de almacenamiento para la tabla empleado-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaEmpleado
(
    @id int ,
    @idUsuarioSistema int,
    @nombre varchar(50),
    @apellido varchar(50),
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@fechaNacimiento datetime,
	@correo varchar(50),
	@direccion varchar(250),
	@idDepartamento int,
	@idPuesto int,
	@telefono varchar(15),
	@celular varchar(15), 
	@fechaIngreso datetime,	
	@vacacionesDisponibles int,
	@idSalario int
	
)

as
begin
insert into db_soportic.dbo.tbl_empleados(idUsuarioSistema,nombre,apellido,idTipoIdentificacion,identificacion,
	fechaNacimiento,correo,direccion,idDepartamento,idPuesto,telefono, celular, fechaIngreso,	
	vacacionesDisponibles,idSalario) 
values( @idUsuarioSistema,@nombre,@apellido,@idTipoIdentificacion,@identificacion,@fechaNacimiento,
	@correo,@direccion,@idDepartamento,@idPuesto,@telefono,@celular, @fechaIngreso,	@vacacionesDisponibles,
	@idSalario)
end

go

create procedure stp_modificarEmpleado
(
    @id int ,
    @idUsuarioSistema int,
    @nombre varchar(50),
    @apellido varchar(50),
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@fechaNacimiento datetime,
	@correo varchar(50),
	@direccion varchar(250),
	@idDepartamento int,
	@idPuesto int,
	@telefono varchar(15),
	@celular varchar(15), 
	@fechaIngreso datetime,	
	@vacacionesDisponibles int,
	@idSalario int
)
as
begin
update   db_soportic.dbo.tbl_empleados
set identificacion = @identificacion
where idEmpleado = @id
end

go

create procedure stp_traeInfoEmpleado
(
@id int
)
as
begin
select *from  db_soportic.dbo.tbl_empleados where idEmpleado = @id
end

go


---------------------------Procedure de almacenamiento para la tabla Usuarios Sistema-----------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaUsuariosSistema
(
 	@id int ,
	@nombreUsuarioSistema varchar(10),
	@contrasenna varchar(200),
	@idRol int
	
)
as
begin
insert into db_soportic.dbo.tbl_usuariosSistema(nombreUsuarioSistema,contrasenna,idRol) 
values(@nombreUsuarioSistema,@contrasenna,@idRol)
end

go

create procedure stp_modificarUsuariosSistema
(
    @id int ,
	@nombreUsuarioSistema varchar(10),
	@contrasenna varchar(200),
	@idRol int
)
as
begin
update  db_soportic.dbo.tbl_usuariosSistema
set nombreUsuarioSistema = @nombreUsuarioSistema
where idUsuarioSistema= @id
end

go

create procedure stp_traeInfoUsuariosSistema
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_usuariosSistema where idUsuarioSistema = @id
end

go



---------------------------Procedure de almacenamiento para la tabla tickets--------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaTickets
(
    @id int,
	@idClienteUsuarioFinal int,
	@idDepartamento int,
	@titulo varchar (200),
	@idTipoServicio int,
	@descripcion varchar (max),
	@idArchivoAdjunto int,
	@fechaRegistro date,
	@idEstatusTickets int,
	@idPrioridad int,
	@idEmpleado int,
	@fechaAsignacion date,
	@fechaInicio date,
	@fechaEntrega date 
)
as
begin
insert into  db_soportic.dbo.tbl_tickets(idClienteUsuarioFinal,idDepartamento,titulo,idTipoServicio,descripcion,
idArchivoAdjunto,fechaRegistro,idEstatusTickets,idPrioridad,idEmpleado,fechaAsignacion,fechaInicio,
fechaEntrega) 
values(@idClienteUsuarioFinal,@idDepartamento,@titulo,@idTipoServicio,@descripcion,@idArchivoAdjunto,
	@fechaRegistro,@idEstatusTickets,@idPrioridad,@idEmpleado,@fechaAsignacion,@fechaInicio,@fechaEntrega)
end

go

create procedure stp_modificarTickets
(
    @id int,
	@idClienteUsuarioFinal int,
	@idDepartamento int,
	@titulo varchar (200),
	@idTipoServicio int,
	@descripcion varchar (max),
	@idArchivoAdjunto int,
	@fechaRegistro date,
	@idEstatusTickets int,
	@idPrioridad int,
	@idEmpleado int,
	@fechaAsignacion date,
	@fechaInicio date,
	@fechaEntrega date 
)
as
begin
update   db_soportic.dbo.tbl_tickets
set descripcion = @descripcion
where idTicket = @id
end

go

create procedure stp_traeInfoTickets
(
@id int
)
as
begin
select *from  db_soportic.dbo.tbl_tickets where idTicket = @id
end

go


---------------------------Procedure de almacenamiento para la tabla Bitacora-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaBitacora
(
    @id int,
	@idTicket int,
	@tiempoLaborado int,
	@descripcion varchar(MAX),
	@idArchivoAdjunto int,	
	@fecha date,
	@idEmpleado int
	
)
as
begin
insert into db_soportic.dbo.tbl_bitacoras(idTicket,tiempoLaborado,descripcion,idArchivoAdjunto,idEmpleado) 
values(@idTicket,@tiempoLaborado,@descripcion,@idArchivoAdjunto,@fecha,@idEmpleado)
end

go

create procedure stp_modificarBitacora
(
     @id int,
	 @idTicket int,
	 @tiempoLaborado int,
	 @descripcion varchar(MAX),
	 @idArchivoAdjunto int,	
	 @fecha date,
	 @idEmpleado int
)
as
begin
update  db_soportic.dbo.tbl_bitacoras
set descripcion = @descripcion
where idBitacora = @id
end

go

create procedure stp_traeInfoBitacora
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_bitacoras where idBitacora = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Vacaciones-----------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaVacaciones
(
    @id int,
	@idEmpleado int,
	@fechaInicio date,
	@fechaFin date,
	@diasSolicitados int,
	@idAprobacionVacacion int
	
)
as
begin
insert into db_soportic.dbo.tbl_vacaciones(idEmpleado,fechaInicio,fechaFin,diasSolicitados,idAprobacionVacacion) 
values(@idEmpleado,@fechaInicio,@fechaFin,@diasSolicitados,@idAprobacionVacacion)
end

go

create procedure stp_modificarVacaciones
(
    @id int,
	@idEmpleado int,
	@fechaInicio date,
	@fechaFin date,
	@diasSolicitados int,
	@idAprobacionVacacion int
)
as
begin
update  db_soportic.dbo.tbl_vacaciones
set descripcion = @descripcion--- ¿?--- no supe qué poner O.o ----
where idSolicitudVacacion = @id
end----Revisarlo ----

go

create procedure stp_traeInfoVacaciones
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_vacaciones where idSolicitudVacacion = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Incapacidades-----------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaIncapacidades
(
    @id int,
	@idEmpleado int,
	@diaInicio date,
	@diaFin date,
	@totalDias int
	
)
as
begin
insert into db_soportic.dbo.tbl_incapacidades(idEmpleado,diaInicio,diaFin,totalDias) 
values(@idEmpleado,@diaInicio,@diaFin,@totalDias)
end

go

create procedure stp_modificarIncapacidades
(
    @id int,
	@idEmpleado int,
	@diaInicio date,
	@diaFin date,
	@totalDias int
)
as
begin
update  db_soportic.dbo.tbl_incapacidades
set descripcion = @descripcion--- ¿?--- no supe qué poner O.o ----
where idIncapacidad = @id
end----Revisarlo ----

go

create procedure stp_traeInfoIncapacidades
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_incapacidades where idIncapacidad = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Proveedores-----------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaProveedores
(
    @id int,
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@nombre varchar(50),
	@direccion varchar(250),
	@telefono varchar(15)
	
)
as
begin
insert into db_soportic.dbo.tbl_clientesProveedores(idTipoIdentificacion,identificacion,nombre,
	direccion, telefono) 
values(@idTipoIdentificacion,@identificacion,@nombre,@direccion,@telefono)
end

go

create procedure stp_modificarProveedores
(
    @id int,
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@nombre varchar(50),
	@direccion varchar(250),
	@telefono varchar(15)
)
as
begin
update  db_soportic.dbo.tbl_clientesProveedores
set identificacion = @identificacion
where idProveedor = @id
end

go

create procedure stp_traeInfoProveedores
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_clientesProveedores where idProveedor = @id
end

go

------------------------Procedure de almacenamiento para la tabla Ordenes de Compra----------------
---------------------------------------------------------------------------------------------------

create procedure stp_insertaOrdenesCompra
(
    @id int,
	@idTicket int,
	@idProveedor int,
	@numeroCotizacion int,
	@detalle varchar(250),
	@monto int,
	@idArchivoAdjunto int	
)
as
begin
insert into db_soportic.dbo.tbl_ordenCompras(idTicket,idProveedor,numeroCotizacion,
	detalle,monto,idArchivoAdjunto) 
values(@idTicket,@idProveedor,@numeroCotizacion,@detalle,@monto,@idArchivoAdjunto)
end

go

create procedure stp_modificarOrdenesCompra
(
    @id int,
	@idTicket int,
	@idProveedor int,
	@numeroCotizacion int,
	@detalle varchar(250),
	@monto int,
	@idArchivoAdjunto int
)
as
begin
update  db_soportic.dbo.tbl_ordenCompras
set detalle= @detalle
where idOrdenCompra = @id
end

go

create procedure stp_traeInfoOrdenesCompra
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_ordenCompras where idOrdenCompra = @id
end

go


---------------------------Procedure de almacenamiento para la tabla Facturas-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaFacturas
(
    @id int,
	@idClienteUsuarioFinal int,
	@telefono varchar(15),
	@direccion varchar(250),
	@fechaFactura date,
	@fechaDesde date,
	@fechaHasta date,
	@detalle varchar(250),
	@subTotal int,
	@impuesto int,
	@total int
	
)
as
begin
insert into db_soportic.dbo.tbl_facturas(idClienteUsuarioFinal,telefono,direccion,fechaFactura,fechaDesde, 
	fechaHasta,detalle,subTotal,impuesto,total) 
values(@idClienteUsuarioFinal,@telefono, @direccion,@fechaFactura,@fechaDesde,@fechaHasta,
	@detalle,@subTotal,@impuesto,@total)
end

go

create procedure stp_modificarFacturas
(
    @id int,
	@idClienteUsuarioFinal int,
	@telefono varchar(15),
	@direccion varchar(250),
	@fechaFactura date,
	@fechaDesde date,
	@fechaHasta date,
	@detalle varchar(250),
	@subTotal int,
	@impuesto int,
	@total int
)
as
begin
update  db_soportic.dbo.tbl_facturas
set detalle = @detalle
where idFactura = @id
end

go

create procedure stp_traeInfoFacturas
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_facturas where idFactura = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Alertas-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaAlertas
(
    @id int,
	@idTipoAlerta int,
	@detalle varchar(250),
	@idEmpleado int,
	@fechaSuceso datetime,
	@fechaFinalizacion datetime,
	@idPrioridad int,
	@idEstatusAlertas int
	
)
as
begin
insert into db_soportic.dbo.tbl_alertas(idTipoAlerta,detalle,idEmpleado,fechaSuceso,fechaFinalizacion,
	idPrioridad,idEstatusAlertas) 
values(	@idTipoAlerta,@detalle,@idEmpleado,@fechaSuceso,@fechaFinalizacion,@idPrioridad,
        @idEstatusAlertas)
end

go

create procedure stp_modificarAlertas
(
    @id int,
    @idTipoAlerta int,
	@detalle varchar(250),
	@idEmpleado int,
	@fechaSuceso datetime,
	@fechaFinalizacion datetime,
	@idPrioridad int,
	@idEstatusAlertas int
)
as
begin
update  db_soportic.dbo.tbl_alertas
set detalle = @detalle
where idAlerta = @id
end

go

create procedure stp_traeInfoAlertas
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_alertas where idAlerta = @id
end

go

---------------------------Procedure de almacenamiento para la tabla Alertas-------------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaAlertas
(
    @id int,
	@idTipoAlerta int,
	@detalle varchar(250),
	@idEmpleado int,
	@fechaSuceso datetime,
	@fechaFinalizacion datetime,
	@idPrioridad int,
	@idEstatusAlertas int
	
)
as
begin
insert into db_soportic.dbo.tbl_alertas(idTipoAlerta,detalle,idEmpleado,fechaSuceso,fechaFinalizacion,
	idPrioridad,idEstatusAlertas) 
values(	@idTipoAlerta,@detalle,@idEmpleado,@fechaSuceso,@fechaFinalizacion,@idPrioridad,
        @idEstatusAlertas)
end

go

create procedure stp_modificarAlertas
(
    @id int,
    @idTipoAlerta int,
	@detalle varchar(250),
	@idEmpleado int,
	@fechaSuceso datetime,
	@fechaFinalizacion datetime,
	@idPrioridad int,
	@idEstatusAlertas int
)
as
begin
update  db_soportic.dbo.tbl_alertas
set detalle = @detalle
where idAlerta = @id
end

go

create procedure stp_traeInfoAlertas
(
@id int
)
as
begin
select *from db_soportic.dbo.tbl_alertas where idAlerta = @id
end

go



----------------Procedure login--------------

create procedure [spu_login]
(
	@nombreUsuarioSistema varchar(15),
	@contrasenna varchar(200)
)
as
	begin
		declare @passCheck varchar(200)
	
		set @passCheck = (select contrasenna from [db_soportic].[dbo].[tbl_usuariosSistema]
						  where nombreUsuarioSistema = @nombreUsuarioSistema)
	
		if @contrasenna = @passCheck
			begin
				select 1 as validacion
			end
		else
			begin
				select 0 as validacion
			end
	end
go
