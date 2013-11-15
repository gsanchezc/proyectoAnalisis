
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
	where idArchivoAdjunto = @id
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

-----------------RAFAEL SEQUEIRA VARGAS-------------------
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

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Procedure Existe Usuario --------------
create procedure [spu_existeUsuario]
(
	@nombreUsuarioSistema varchar(15)
)
as
	begin
		declare @idUsuarioSistema int
		
		set @idUsuarioSistema = (select idUsuarioSistema
								 from dbo.tbl_usuariosSistema
								 where nombreUsuarioSistema = @nombreUsuarioSistema)
	
		if exists(select * 
				  from [db_soportic].[dbo].[vw_usuariosCombinados]
				  where idUsuarioSistema = @idUsuarioSistema)
			begin
				select 1 as validacion
			end
		else
			begin
				select 0 as validacion
			end
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Procedure Existe Usuario de Login
create procedure [spu_existeNombreDeUsuario]
(
	@nombreUsuarioSistema varchar(15)
)
as
	begin
		if exists(select * 
				  from dbo.tbl_usuariosSistema
				  where nombreUsuarioSistema = @nombreUsuarioSistema)
			begin
				select 1 as validacion
			end
		else
			begin
				select 0 as validacion
			end
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Vista de Usuarios Combiandos --------------
create view [vw_usuariosCombinados]
as
select idUsuarioSistema, nombre, identificacion
from dbo.tbl_clientesUsuarioFinal
UNION
select idUsuarioSistema, nombre, identificacion
from dbo.tbl_empleados
go	

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Procedure Carga Rol Usuario --------------
create procedure [spu_cargaRolConIdUsuario]
(
	@idUsuarioSistema int
)
as
	begin
		select idRol as Id_Rol from [db_soportic].[dbo].[tbl_usuariosSistema]
		where idUsuarioSistema = @idUsuarioSistema
	end
go

create procedure [spu_cargaRol]
(
	@nombreUsuario varchar(10)
)
as
	begin
		select idRol as Id_Rol from [db_soportic].[dbo].[tbl_usuariosSistema]
		where nombreUsuarioSistema = @nombreUsuario
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Procedure Insertar Nuevo Cliente Usuario Final--------------
create procedure [spu_insertarNuevoClienteUsuarioFinal]
(
	@nombre varchar(50),
	@apellidos varchar(50),
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@telefonoEmpresa varchar(15),
	@idEmpresaCliente int,
	@isDeleted bit
)
as
	begin
		declare @idUsuarioSistema int
		
		set @idUsuarioSistema = null;
		
		insert into [db_soportic].[dbo].[tbl_clientesUsuarioFinal]
		values (@idUsuarioSistema, @nombre, @apellidos, @idTipoIdentificacion, @identificacion, @telefonoEmpresa, @idEmpresaCliente, @isDeleted)
	end
go

-----------------RAFAEL SEQUEIRA VARGAS---------------------------
----------------Procedure Cargar ComboBox Tipo ID-----------------
create procedure [spu_cargaComboBoxTipoId]
as
	begin
		select idTipoIdentificacion, descripcion from [db_soportic].[dbo].[tbl_tipoIdentificaciones]
	end
go

-----------------RAFAEL SEQUEIRA VARGAS---------------------------
----------------Procedure Cargar ComboBox Empresa Cliente---------
create procedure [spu_cargaComboBoxEmpresaCliente]
as
	begin
		select idEmpresaCliente, nombre from [db_soportic].[dbo].[tbl_empresasClientes]
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA LISTA ID CLIENTES
create procedure [spu_cargaListaIDClientes]
as
	begin
		select dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal, dbo.tbl_clientesUsuarioFinal.idUsuarioSistema, dbo.tbl_clientesUsuarioFinal.nombre,
        dbo.tbl_clientesUsuarioFinal.apellidos, dbo.tbl_clientesUsuarioFinal.identificacion
		from dbo.tbl_clientesUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA LISTA ID EMPLEADOS
create procedure [spu_cargaListaIDEmpleados]
as
	begin
		select idEmpleado
		from tbl_empleados
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA LISTA ID CLIENTES
create procedure [spu_cargaListaIDClientes]
as
	begin
		select idClienteUsuarioFinal
		from tbl_clientesUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA INFORMACION USUARIO EMPLEADO
create procedure [spu_cargaInfoEmpleado]
(
	@idEmpleado int
)
as
	begin
		select *
		from tbl_empleados
		where idEmpleado = @idEmpleado
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA INFORMACION USUARIO CLIENTE
create procedure [spu_cargaInfoCliente]
(
	@idClienteUsuarioFinal int
)
as
	begin
		select *
		from tbl_clientesUsuarioFinal
		where idClienteUsuarioFinal = @idClienteUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--INSERTA USUARIO SISTEMA
create procedure [spu_insertaUsuarioSistema]
(
	@nombreUsuarioSistema varchar(10),
	@contrasenna varchar(200),
	@idRol int,
	@isBlocked bit,
	@isdeleted bit
)
as
	begin
		insert into tbl_usuariosSistema
		values (@nombreUsuarioSistema, @contrasenna, @idRol, @isBlocked, @isdeleted)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA ID USUARIO SISTEMA CLIENTE
create procedure [spu_traeIdUsuarioSistema]
(
	@idClienteUsuarioFinal int
)
as
	begin
		declare @idUsuarioSistema int
	
		set @idUsuarioSistema = (select idUsuarioSistema from dbo.tbl_clientesUsuarioFinal
								where idClienteUsuarioFinal = @idClienteUsuarioFinal)
		
		if(@idUsuarioSistema is null)
			begin
				set @idUsuarioSistema = 0
				select @idUsuarioSistema as idUsuarioSistema
			end
		else
			begin
				select @idUsuarioSistema as idUsuarioSistema
			end
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA ID USUARIO SISTEMA EMPLEADO
create procedure [spu_traeIdUsuarioSistemaEmpleado]
(
	@idEmpleado int
)
as
	begin
		declare @idUsuarioSistema int
	
		set @idUsuarioSistema = (select idUsuarioSistema from dbo.tbl_empleados
								where idEmpleado = @idEmpleado)
		
		if(@idUsuarioSistema is null)
			begin
				set @idUsuarioSistema = 0
				select @idUsuarioSistema as idUsuarioSistema
			end
		else
			begin
				select @idUsuarioSistema as idUsuarioSistema
			end
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA ID USUARIO CON NOMBRE DE USUARIO
create procedure [spu_traeIDUsuario]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		select idUsuarioSistema from dbo.tbl_usuariosSistema
		where nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--ACTUALIZA ID USUARIO SISTEMA CLIENTE
create procedure [spu_actualizaIdUsuarioSistemaCliente]
(
	@idClienteUsuarioFinal int,
	@idUsuarioSistema int
)
as
	begin
		update dbo.tbl_clientesUsuarioFinal
		set idUsuarioSistema = @idUsuarioSistema
		where idClienteUsuarioFinal = @idClienteUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--ACTUALIZA ID USUARIO SISTEMA EMPLEADO
create procedure [spu_actualizaIdUsuarioSistemaEmpleado]
(
	@idEmpleado int,
	@idUsuarioSistema int
)
as
	begin
		update dbo.tbl_empleados
		set idUsuarioSistema = @idUsuarioSistema
		where idEmpleado = @idEmpleado
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--VALIDA ESTATUS DE CUENTA USUARIO
create procedure [spu_validaEstatusDeCta]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		select isBlocked from dbo.tbl_usuariosSistema
		where nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--ACTUALIZA USUARIOS SISTEMA CAMPOS (NOMBRE Y CONTRASENA)
create procedure [spu_actualizaUsuariosSistema]
(
	@idUsuarioSistema int,
	@nombreUsuarioSistema varchar(10),
	@contrasenna varchar(200)
)
as
	begin
		update dbo.tbl_usuariosSistema
		set nombreUsuarioSistema = @nombreUsuarioSistema,
			contrasenna = @contrasenna
		where idUsuarioSistema = @idUsuarioSistema
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--BLOQUEA / DESBLOQUEA CUENTA CON ID DE USUARIO SISTEMA
create procedure [spu_bloqueaDesbloqueaUsuario]
(
	@idUsuarioSistema int,
	@isBlocked bit
)
as
	begin
		update dbo.tbl_usuariosSistema
		set isBlocked = @isBlocked
		where idUsuarioSistema = @idUsuarioSistema
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--BLOQUEA CUENTA CON NOMBRE DE USUARIO
create procedure [spu_bloqueaUsuarioEnLogin]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		update dbo.tbl_usuariosSistema
		set isBlocked = 1
		where nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--ACTUALIZA ROL CON ID DE USUARIO SISTEMA
create procedure [spu_actualizaRol]
(
	@idUsuarioSistema int,
	@idRol int
)
as
	begin
		update dbo.tbl_usuariosSistema
		set idRol = @idRol
		where idUsuarioSistema = @idUsuarioSistema
	end
go

create procedure [dbo].[spu_cargaRolUsuario]
(
 @nombreUsuario varchar(10)
)
as
 begin
  select idRol as Id_Rol from [db_soportic].[dbo].[tbl_usuariosSistema]
  where nombreUsuarioSistema = @nombreUsuario
 end

GO