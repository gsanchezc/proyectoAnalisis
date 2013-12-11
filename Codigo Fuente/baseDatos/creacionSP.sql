use db_soportic
go

----------------------------------------------------------------------------------------
--------------------------------SP - DIEGO VENEGAS MONGE------------------------------------
-----------------------------------------------------------------------------------------------
-------------Procedure que realiza borrado logico de un Cliente proveedor de la tabla tbl_tipoClientesProveedores DVM------
create procedure stp_borrarTipoClienteProveedor
(
	@id int
)
as
begin
	update db_soportic.dbo.tbl_tipoClientesProveedores set isDeleted = 1
	where idTipoClienteProveedor = @id
end
go

--------Procedure que trae/jala la informacion de la tabla tbl_tipoIdentificacion DVM--------
create procedure stp_traeTipoIdentificacion
as
begin
	select *
	from tbl_tipoIdentificaciones where isDeleted=0
end
go

----------Procedure de borrado---------
create procedure stp_borrarTipoIdentificacion
(
   @id int
)

as
begin
	update db_soportic.dbo.tbl_tipoIdentificaciones set isDeleted = 1
    where idTipoIdentificacion = @id
end

go

-----------Procedure que trae el Estatus de Tickets-----------------------
create procedure stp_traeEstatusTickets
as
begin
	select idEstatusTickets, descripcion 
	from tbl_estatusTickets where isDeleted=0
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
	update db_soportic.dbo.tbl_estatusTickets set isDeleted = 1
	where idEstatusTickets = @id
end

go

---------------Procedure que inserta datos en la tabla tbl_tipoPrioridades-----------------------------
create procedure stp_insertarTipoPrioridad
(
	@id int,
	@descripcion varchar (50)
)

as
begin
		insert into db_soportic.dbo.tbl_tipoPrioridades(descripcion) 
		values(@descripcion)
end

go

----------------------Procedure que modifica y actualiza los datos tbl_tipoPrioridades-----------------------------
create procedure stp_modificarTipoPrioridada
(
		@id int,
		@descripcion varchar(50)
)

 as
 begin
	update db_soportic.dbo.tbl_tipoPrioridades set descripcion = @descripcion
	where idPrioridad = @id
 end

go

---------------------Procedure que trae/jala la informacion tbl_tipoPrioridades-------------------
create procedure stp_traeInfoTipoPrioridad
(
    @id int
)

 as
 begin
	select *
	from db_soportic.dbo.tbl_tipoPrioridades where idPrioridad = @id
 end

go

-----------Procedure que trae tbl_tipoPrioridades-----------------------
create procedure stp_traeTipoPrioridad
as
begin
	select idPrioridad, descripcion 
	from tbl_tipoPrioridades where isDeleted=0
end
go

---------------Procedure de borrado de tipo de prioridad----------------------
create procedure stp_borrarTipoPrioridad
(
		@id int
)

as
begin
	update db_soportic.dbo.tbl_tipoPrioridades set isDeleted = 1
	where idPrioridad = @id
end

go
---------------------------------------------------------------------------------------
------------Store procedure para cargar todas las incapacidades--------
create procedure stp_traeIncapacidades
as
begin
	Select * from tbl_incapacidades where isDeleted=0
end

go

-----------procedure para ingresar nuevo empleado-------------------
create procedure stp_insertarNuevoEmpleado
(
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
	@idsalario int	
)
as
begin
	insert into db_soportic.dbo.tbl_empleados(nombre, apellido,idTipoIdentificacion,identificacion,fechaNacimiento,
							correo,direccion,idDepartamento,idPuesto,telefono,celular,fechaIngreso,idSalario) 
	values(@nombre,@apellido,@idTipoIdentificacion,@identificacion,@fechaNacimiento,@correo,@direccion,
				@idDepartamento,@idPuesto,@telefono,@celular,@fechaIngreso,@idsalario)

end

go

--------------Procedure que trae la Descripcion de Departamentos-----------------
create procedure stp_traeDescripcionDepartamentos

as
begin
	select idDepartamento, descripcion 
	from tbl_Departamentos where isDeleted=0
end

go

----------------procedue para traer salarios------------------------
create procedure stp_traeSalarios
as
begin
	select idSalario,monto from tbl_salarios where isDeleted=0
end
go

---------------procedure para crear solicitud de vacaciones---------------------
create procedure stp_SolicitudVaciones
(
	@idEmpleado int,
	@fechaInicio datetime,
	@fechaFin datetime,
	@diasSolicitados int
)
as
begin
	insert into tbl_vacaciones (idEmpleado,fechaInicio,fechaFin,diasSolicitados)
	values(@idEmpleado,@fechaInicio,@fechaFin,@diasSolicitados)
end
go

---------------------procedure para cargar lista de empleados----------
create procedure stp_traeListaEmpleados
as
begin
	select idEmpleado,identificacion from tbl_empleados where isDeleted=0
end
go

-------------------carga informacion de dais de vacaciones disponibles--
create procedure stp_VacacionesDisponibles
(
	@identificacion int
)
as
begin
	select vacacionesDisponibles from tbl_empleados where identificacion=@identificacion
end
go

----------------guarda nueva nomina----------------
create procedure stp_insertNuevaNomina
(
	@idEmpleado int,
	@mesNomina varchar(15),
	@anioNomina int,
	@horasLaboradas int,
	@horasExtra int,
	@salario float,
	@salarioBruto float,
	@rebajos float,
	@salarioNeto float
)
as
begin
	insert into db_soportic.dbo.tbl_nomina (idEmpleado, mesNomina, anioNomina,horasLaboradas,horasExtra,salario,salarioBruto,rebajos,salarioNeto)
	values(@idEmpleado,@mesNomina,@anioNomina,@horasLaboradas,@horasExtra,@salario,@salarioBruto,@rebajos,@salarioNeto)

end
go
-------------------carga el salario del empleado solicitado--------
create procedure stp_salarioEmpleado
(
	@idEmpleado int
)
as
begin
	select monto from db_soportic.dbo.tbl_salarios where idEmpleado=@idEmpleado
end
go

---------------------------------------------------------------------------------------
---------------------------FIN SP DIEGO VENEGAS M--------------------------------------
---------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
---Procedimientos almacenados para la tabla Descripcion Roles----------------------------
create procedure stp_insertarDescripcionRol
(
	@id int,
	@descripcion varchar(50)
)
as
	begin
		insert into tbl_descripcionRoles(descripcion) 
		values(@descripcion)
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
		select *
		from tbl_descripcionRoles 
		where idRol = @id
	end
go

create procedure stp_traeDescripcionRol
as
	begin
		select idRol, 
			   descripcion 
		from tbl_descripcionRoles
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
		insert into tbl_tipoPuestos(descripcion) 
		values(@descripcion)
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
		select *
		from tbl_tipoPuestos 
		where idPuesto = @id
	end
go

create procedure stp_traeTipoPuestos
as
	begin
		select idPuesto, 
		       descripcion 
		from tbl_tipoPuestos
	end
GO

----------------------------------------------------------------------------------------
create procedure stp_insertaTipoIdentificacion
(
	@id int,
	@descripcion varchar(50)
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
		update db_soportic.dbo.tbl_tipoIdentificaciones 
		set descripcion = @descripcion
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
		from tbl_tipoIdentificaciones 
		where idTipoIdentificacion = @id
	end
go

---------------Procedure que inserta datos en la tabla tbl_estatusTickets-----------------------------
create procedure stp_insertarEstatusTickets
(
	@id int, 
	@descripcion varchar (50)
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
		update db_soportic.dbo.tbl_estatusTickets 
		set descripcion = @descripcion
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
		from db_soportic.dbo.tbl_estatusTickets 
		where idEstatusTickets = @id
	end
go


---------------------------Procedure de almacenamiento para la tabla descripcionDepartamentos-------------
----------------------------------------------------------------------------------------------------------
------------------Procedure que modifica y actualiza datos en la tabla tbl_descripionDepartamentos----------
create procedure stp_modificarDescripcionDepartamentos
(
	@id int,
	@descripcion varchar(50)
)
as
	begin
		update db_soportic.dbo.tbl_descripcionDepartamentos 
		set descripcion = @descripcion
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
		from tbl_descripcionDepartamentos 
		where idDepartamento = @id
	end
go

----------------Procedure de borrado Descripcion Depatamentos DVM------------------------------
create procedure stp_borrarDescripcionDepartamentos
(
		@id int
)

as
begin
	update db_soportic.dbo.tbl_descripcionDepartamentos set isDeleted = 1
	where idDepartamento  = @id
end

go

---------------------------Procedure de almacenamiento para la tabla datosAdjuntos--------------------
------------------------------------------------------------------------------------------------------
------------------Procedure que inserta datos en la tabla tbl_datosAdjuntos-------------------------
create procedure stp_insertarDatosAdjuntos
(
	@id int, 
	@archivo varbinary(max)
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
		update tbl_datosAdjuntos 
		set archivo = @archivo
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
		from tbl_datosAdjuntos 
		where idArchivoAdjunto  = @id
	end
go

----------------Procedure que trae los datos Adjuntos de la tabla tbl_datosAdjuntos--------------
create procedure stp_traeDatosAdjuntos
as
	begin
		select idArchivoAdjunto, 
			   archivo 
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
	
		set @passCheck = (select contrasenna 
						  from [db_soportic].[dbo].[tbl_usuariosSistema]
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
		select idRol as Id_Rol 
		from [db_soportic].[dbo].[tbl_usuariosSistema]
		where idUsuarioSistema = @idUsuarioSistema
	end
go

create procedure [spu_cargaRol]
(
	@nombreUsuario varchar(10)
)
as
	begin
		select idRol as Id_Rol 
		from [db_soportic].[dbo].[tbl_usuariosSistema]
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
		values (@idUsuarioSistema, 
				@nombre, 
				@apellidos, 
				@idTipoIdentificacion, 
				@identificacion, 
				@telefonoEmpresa, 
				@idEmpresaCliente, 
				@isDeleted)
	end
go

-----------------RAFAEL SEQUEIRA VARGAS---------------------------
----------------Procedure Cargar ComboBox Tipo ID-----------------
create procedure [spu_cargaComboBoxTipoId]
as
	begin
		select idTipoIdentificacion, 
		       descripcion 
		from [db_soportic].[dbo].[tbl_tipoIdentificaciones]
	end
go

-----------------RAFAEL SEQUEIRA VARGAS---------------------------
----------------Procedure Cargar ComboBox Empresa Cliente---------
create procedure [spu_cargaComboBoxEmpresaCliente]
as
	begin
		select idEmpresaCliente, 
			   nombre 
		from [db_soportic].[dbo].[tbl_empresasClientes]
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--CARGA LISTA ID CLIENTES
create procedure [spu_cargaListaIDClientes]
as
	begin
		select dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal, 
			   dbo.tbl_clientesUsuarioFinal.idUsuarioSistema, 
			   dbo.tbl_clientesUsuarioFinal.nombre,
			   dbo.tbl_clientesUsuarioFinal.apellidos, 
			   dbo.tbl_clientesUsuarioFinal.identificacion
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
		values (@nombreUsuarioSistema, 
				@contrasenna, 
				@idRol, 
				@isBlocked, 
				@isdeleted)
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
	
		set @idUsuarioSistema = (select idUsuarioSistema 
								 from dbo.tbl_clientesUsuarioFinal
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
	
		set @idUsuarioSistema = (select idUsuarioSistema 
								 from dbo.tbl_empleados
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

-----------------RAFAEL SEQUEIRA VARGAS---------------------------------------------
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

--------RAFAEL SEQUEIRA VARGAS------------
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

--------RAFAEL SEQUEIRA VARGAS------------
--------------------Procedure que trae/jala la informacion dela tabla tbl_tipoServicio-------------
create procedure stp_traeInfoTipoServicio
(
    @id int
)
as
begin
	select idTipoServicio, descripcion
	from tbl_tipoServicio where idTipoServicio  = @id
end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure que trae los datos de la tabla tbl_tipoServicio--------------
create procedure [stp_traeTipoServicio]

as
begin
	select idtipoServicio, descripcion
	from tbl_tipoServicio
end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [stp_insertarArchivoAdjunto]
(
	@nombre varchar(200),
	@archivo image,
	@isDeleted bit
)
as
	begin
		insert into dbo.PDFupload(fname,fcontent) 
		values (@nombre, @archivo, @isDeleted)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [stp_cargaArchivoAdjunto]
(
	@ID int
)
as
	begin
		select * from dbo.PDFupload
		where ID = @ID
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [stp_cargaIdArchivoAdjuntoRecienGuardado]
as
	begin
		select MAX(idArchivoAdjunto) as ID from dbo.tbl_datosAdjuntos
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_insertarTicket]
(
	@idClienteUsuarioFinal int,
	@idDepartamento int,
	@titulo varchar(200),
	@idTipoServicio int,
	@descripcion varchar(max),
	@idArchivoAdjunto int,
	@fechaRegistro date,
	@idEstatusTickets int,
	@idPrioridad int,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_tickets
		values (
					@idClienteUsuarioFinal, @idDepartamento, @titulo, @idTipoServicio, @descripcion, 
					@idArchivoAdjunto, @fechaRegistro, @idEstatusTickets, @idPrioridad, Null,
					null, null, null, @isDeleted, null, 0
				)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_insertarTicketSinArchivoAdjunto]
(
	@idClienteUsuarioFinal int,
	@idDepartamento int,
	@titulo varchar(200),
	@idTipoServicio int,
	@descripcion varchar(max),
	@fechaRegistro date,
	@idEstatusTickets int,
	@idPrioridad int,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_tickets
		values (
					@idClienteUsuarioFinal, @idDepartamento, @titulo, @idTipoServicio, @descripcion, 
					null, @fechaRegistro, @idEstatusTickets, @idPrioridad, Null,
					null, null, null, @isDeleted, null, 0
				)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_cargaIdClienteUsuarioFinal]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		select * from dbo.tbl_clientesUsuarioFinal, dbo.tbl_usuariosSistema 
		where dbo.tbl_clientesUsuarioFinal.idUsuarioSistema = dbo.tbl_usuariosSistema.idUsuarioSistema
		and nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataTicketsSinAsignarYPendientesAprobacion]
as
	begin
	   select idTicket, 
			  dbo.tbl_clientesUsuarioFinal.nombre +' '+apellidos as idClienteUsuarioFinal, 
			  dbo.tbl_Departamentos.descripcion as idDepartamento,
			  dbo.tbl_tipoServicio.descripcion as idTipoServicio, 
			  fechaRegistro, 
			  dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			  dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			  dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as idEmpleado,
			  fechaAsignacion,
			  fechaInicio,
			  fechaEntrega
		 from dbo.tbl_tickets 
			  left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_tickets.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
			  left outer join dbo.tbl_Departamentos on dbo.tbl_tickets.idDepartamento = dbo.tbl_Departamentos.idDepartamento
			  left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
			  left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
			  left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
			  left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		where dbo.tbl_tickets.idEstatusTickets = 1 or 
		      dbo.tbl_tickets.idEstatusTickets = 3
	end
go
-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataTicketsAsignadosATecnico]
(
	@idEmpleado int
)
as
	begin
	   select idTicket, 
			  dbo.tbl_clientesUsuarioFinal.nombre +' '+ apellidos as idClienteUsuarioFinal, 
			  dbo.tbl_Departamentos.descripcion as idDepartamento,
			  dbo.tbl_tipoServicio.descripcion as idTipoServicio, 
			  fechaRegistro, 
			  dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			  dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			  dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as idEmpleado,
			  fechaAsignacion,
			  fechaInicio,
			  fechaEntrega
		 from dbo.tbl_tickets
			  left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_tickets.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
			  left outer join dbo.tbl_Departamentos on dbo.tbl_tickets.idDepartamento = dbo.tbl_Departamentos.idDepartamento
			  left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
			  left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
			  left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
			  left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		where dbo.tbl_tickets.idEmpleado = @idEmpleado and
			  dbo.tbl_tickets.idEstatusTickets = 2 or
			  dbo.tbl_tickets.idEstatusTickets = 4		  
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataMisTicketPendientesVistaCliente]
(
	@idClienteUsuarioFinal int
)
as
	begin
	    select idTicket, 
			   dbo.tbl_Departamentos.descripcion as idDepartamento,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as idTipoServicio,
			   fechaRegistro, 
			   dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as idEmpleado,
			   fechaAsignacion,
			   fechaInicio,
			   fechaEntrega
		  from dbo.tbl_tickets
			   left outer join dbo.tbl_Departamentos on dbo.tbl_tickets.idDepartamento = dbo.tbl_Departamentos.idDepartamento
			   left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
			   left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
			   left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
			   left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		 where dbo.tbl_tickets.idClienteUsuarioFinal = @idClienteUsuarioFinal and
			   dbo.tbl_tickets.idEstatusTickets <> 5
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataMisTicketCerradosVistaCliente]
(
	@idClienteUsuarioFinal int
)
as
	begin
	    select idTicket, 
			   dbo.tbl_Departamentos.descripcion as idDepartamento,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as idTipoServicio,
			   fechaRegistro, 
			   dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as idEmpleado,
			   fechaAsignacion,
			   fechaInicio,
			   fechaEntrega
		  from dbo.tbl_tickets
			   left outer join dbo.tbl_Departamentos on dbo.tbl_tickets.idDepartamento = dbo.tbl_Departamentos.idDepartamento
			   left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
			   left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
			   left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
			   left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		 where dbo.tbl_tickets.idClienteUsuarioFinal = @idClienteUsuarioFinal and
			   dbo.tbl_tickets.idEstatusTickets = 5
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataBitacora]
as
	begin
	   select idBitacora,
			  idTicket,
			  tiempoLaborado,
			  descripcion,
			  idArchivoAdjunto,
			  fecha,
			  nombre +' '+apellido as idEmpleado
		 from dbo.tbl_bitacoras,
			  dbo.tbl_empleados
		where dbo.tbl_bitacoras.idEmpleado = dbo.tbl_empleados.idEmpleado
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataBitacoraEspecifico]
(
	@idBitacora int
)
as
	begin
	   select idBitacora,
			  idTicket,
			  tiempoLaborado,
			  descripcion,
			  idArchivoAdjunto,
			  fecha,
			  nombre +' '+apellido as idEmpleado
		 from dbo.tbl_bitacoras
			  left outer join dbo.tbl_empleados on dbo.tbl_bitacoras.idEmpleado = dbo.tbl_empleados.idEmpleado
		where idBitacora = @idBitacora
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataBitacoraTicketEspecifico]
(
	@idTicket int
)
as
	begin
	   select idBitacora,
			  idTicket,
			  tiempoLaborado,
			  descripcion,
			  idArchivoAdjunto,
			  fecha,
			  nombre +' '+apellido as idEmpleado
		 from dbo.tbl_bitacoras
			  left outer join dbo.tbl_empleados on dbo.tbl_bitacoras.idEmpleado = dbo.tbl_empleados.idEmpleado
		where idTicket = @idTicket
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDataTicket]
(
	@idTicket int
)
as
	begin
		select idTicket, 
			   dbo.tbl_clientesUsuarioFinal.nombre +' '+ apellidos as nombreUsuario, 
			   dbo.tbl_Departamentos.descripcion as Departamento,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as TipoServicio,
			   dbo.tbl_tickets.descripcion,
			   idArchivoAdjunto as idArchivoAdjunto,
			   fechaRegistro, 
			   dbo.tbl_estatusTickets.descripcion as EstatusTicket,
			   dbo.tbl_tipoPrioridades.descripcion as Prioridad,
			   dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as Empleado,
			   fechaAsignacion,
			   fechaInicio,
			   fechaEntrega,
			   dbo.tbl_tickets.isDeleted,
			   dbo.tbl_tickets.idEstatusTickets,
			   dbo.tbl_tickets.idPrioridad,
			   dbo.tbl_tickets.idEmpleado
		  from dbo.tbl_tickets
			   left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_tickets.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
			   left outer join dbo.tbl_Departamentos on dbo.tbl_tickets.idDepartamento = dbo.tbl_Departamentos.idDepartamento
			   left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
			   left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
			   left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
			   left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		 where idTicket = @idTicket
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_traeInfoTipoPrioridades]
as
	begin
		select * from dbo.tbl_tipoPrioridades
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_cargaComboBoxTecnicos]
as
	begin
		select nombre +' '+ apellido as Empleado, idEmpleado
		from dbo.tbl_empleados, dbo.tbl_usuariosSistema
		where dbo.tbl_empleados.idUsuarioSistema = dbo.tbl_usuariosSistema.idUsuarioSistema and idRol = 3
	end
go


-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_asignacionTicket]
(
	@idTicket int,
	@idEstatusTickets int,
	@idPrioridad int,
	@idEmpleado int,
	@fechaAsignacion date,
	@fechaEntrega date
)
as
	begin
		update dbo.tbl_tickets
		set idEstatusTickets = @idEstatusTickets,
			idPrioridad = @idPrioridad,
			idEmpleado = @idEmpleado,
			fechaAsignacion = @fechaAsignacion,
			fechaEntrega = @fechaEntrega
		where idTicket = @idTicket
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_atencionTicket]
(
	@idTicket int,
	@idEstatusTickets int
)
as
	begin
		update dbo.tbl_tickets
		set idEstatusTickets = @idEstatusTickets
		where idTicket = @idTicket
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_actualizarFechaInicio]
(
	@idTicket int,
	@fechaInicio date
)
as
	begin
		update dbo.tbl_tickets
		set fechaInicio = @fechaInicio
		where idTicket = @idTicket
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_insertBitacora]
(
	@idTicket int,
	@tiempoLaborado int,
	@descripcion varchar(max),
	@idArchivoAdjunto int,
	@fecha date,
	@idEmpleado int,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_bitacoras(idTicket, tiempoLaborado, descripcion, idArchivoAdjunto, fecha, idEmpleado, isDeleted)
		values(@idTicket, @tiempoLaborado, @descripcion, @idArchivoAdjunto, @fecha, @idEmpleado, @isDeleted)
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_insertBitacoraSinArchivoAdjunto]
(
	@idTicket int,
	@tiempoLaborado int,
	@descripcion varchar(max),
	@fecha date,
	@idEmpleado int,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_bitacoras(idTicket, tiempoLaborado, descripcion, idArchivoAdjunto, fecha, idEmpleado, isDeleted)
		values(@idTicket, @tiempoLaborado, @descripcion, null, @fecha, @idEmpleado, @isDeleted)
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_validarBitacoraTicket]
(
	@idTicket int
)
as
	begin
		if exists(select * 
				  from dbo.tbl_bitacoras
				  where idTicket = @idTicket)
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
-------------------------------------------------------------
create procedure [spu_cantidadTicketPendientesSupervisor]
as
	select COUNT(*) as PendientesSupervisor
	from dbo.tbl_tickets
	where idEstatusTickets = 1 or
		  idEstatusTickets = 3
go
-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cantidadTicketPendientesTecnico]
(
	@idEmpleado int
)
as
	select COUNT(*) as PendientesTecnico
	from dbo.tbl_tickets
	where idEmpleado = @idEmpleado and
		  idEstatusTickets = 2 or
		  idEstatusTickets = 4  
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_TicketsVencidos]
as
	begin
		declare @fechaHoy date
		declare @vencidos int
		set @fechaHoy = GETDATE()
		set @vencidos = 0
		
		if exists(select COUNT(*) as vencidos from dbo.tbl_tickets where fechaEntrega < @fechaHoy)
			select COUNT(*) as vencidos from dbo.tbl_tickets where fechaEntrega < @fechaHoy
		else
			begin
				select @vencidos as vencidos
			end
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_TicketsVencidosTecnico]
(
	@idEmpleado int
)
as
	begin
		declare @fechaHoy date
		declare @vencidos int
		set @fechaHoy = GETDATE()
		set @vencidos = 0
		
		if exists(select COUNT(*) as vencidos 
			      from dbo.tbl_tickets 
			      where fechaEntrega < @fechaHoy and
			      idEmpleado = @idEmpleado)
			select COUNT(*) as vencidos 
			from dbo.tbl_tickets 
			where fechaEntrega < @fechaHoy and
			      idEmpleado = @idEmpleado
		else
			begin
				select @vencidos as vencidos
			end
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_cargaIdEmpleadoPorNombreUsuario]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		select idEmpleado
		from dbo.tbl_empleados
		left outer join dbo.tbl_usuariosSistema on dbo.tbl_empleados.idUsuarioSistema = dbo.tbl_usuariosSistema.idUsuarioSistema
		where nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_cargaIdClienteUsuarioFinalPorNombreUsuario]
(
	@nombreUsuarioSistema varchar(10)
)
as
	begin
		select idClienteUsuarioFinal
		from dbo.tbl_clientesUsuarioFinal
		left outer join dbo.tbl_usuariosSistema on dbo.tbl_clientesUsuarioFinal.idUsuarioSistema = dbo.tbl_usuariosSistema.idUsuarioSistema
		where nombreUsuarioSistema = @nombreUsuarioSistema
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaGridAlertasNoFinalizados]
as
	begin
		select idAlerta, 
			   dbo.tbl_TipoAlertas.descripcion as idTipoAlerta,
			   detalle,
			   dbo.tbl_empleados.nombre+' '+dbo.tbl_empleados.apellido as idEmpleado,
			   fechaSuceso,
			   fechaFinalizacion,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   dbo.tbl_estatusAlertas.descripcion as idEstatusAlertas
		from dbo.tbl_alertas
		left outer join dbo.tbl_TipoAlertas on dbo.tbl_alertas.idTipoAlerta = dbo.tbl_TipoAlertas.idTipoAlerta
		left outer join dbo.tbl_empleados on dbo.tbl_alertas.idEmpleado = dbo.tbl_empleados.idEmpleado
		left outer join dbo.tbl_tipoPrioridades on dbo.tbl_alertas.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
		left outer join dbo.tbl_estatusAlertas on dbo.tbl_alertas.idEstatusAlertas = dbo.tbl_estatusAlertas.idEstatusAlertas
		where dbo.tbl_alertas.idEstatusAlertas = 1
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaDetalleAlertasPorEmpleado]
(
	@idEmpleado int
)
as
	begin
		select idAlerta, 
			   dbo.tbl_TipoAlertas.descripcion as idTipoAlerta,
			   detalle,
			   dbo.tbl_empleados.nombre+' '+dbo.tbl_empleados.apellido as idEmpleado,
			   fechaSuceso,
			   fechaFinalizacion,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   dbo.tbl_estatusAlertas.descripcion as idEstatusAlertas,
			   dbo.tbl_alertas.Referencia
		from dbo.tbl_alertas
		left outer join dbo.tbl_TipoAlertas on dbo.tbl_alertas.idTipoAlerta = dbo.tbl_TipoAlertas.idTipoAlerta
		left outer join dbo.tbl_empleados on dbo.tbl_alertas.idEmpleado = dbo.tbl_empleados.idEmpleado
		left outer join dbo.tbl_tipoPrioridades on dbo.tbl_alertas.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
		left outer join dbo.tbl_estatusAlertas on dbo.tbl_alertas.idEstatusAlertas = dbo.tbl_estatusAlertas.idEstatusAlertas
		where dbo.tbl_alertas.idEstatusAlertas = 1 and
			  dbo.tbl_alertas.idEmpleado = @idEmpleado
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [spu_cargaCantidadAlertasPorEmpleado]
(
	@idEmpleado int
)
as
	begin
		declare @cantidadAlertas int
		set @cantidadAlertas = 0
		
		if exists(select COUNT(*) as cantidadAlertas
			      from dbo.tbl_alertas
			      where idEmpleado = @idEmpleado)
			select COUNT(*) as cantidadAlertas
			from dbo.tbl_alertas
			where idEmpleado = @idEmpleado
		else
			begin
				select @cantidadAlertas as cantidadAlertas
			end
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_ultimoRegistroTicket]
as
	begin
		select idTicket
		from dbo.tbl_tickets
		where idTicket = IDENT_CURRENT('dbo.tbl_tickets')
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--INSERTA ALERTA
create procedure [spu_insertaAlerta]
(
	@idTipoAlerta int,
	@detalle varchar (250),
	@idEmpleado int,
	@fechaFinalizacion datetime,
	@idPrioridad int,
	@idEstatusAlertas int,
	@isDeleted bit,
	@Referencia int
)
as
	begin
		declare @fecha datetime
		set @fecha = GETDATE()
	
		insert into dbo.tbl_alertas
		values (@idTipoAlerta, 
		        @detalle, 
		        @idEmpleado, 
		        @fecha, 
		        @fechaFinalizacion, 
		        @idPrioridad, 
		        @idEstatusAlertas, 
		        @isDeleted, 
		        @Referencia)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [stu_actualizarAlertaPorPrioridad]
(
	@Referencia int
)
as
	begin
		if exists(select * 
		          from dbo.tbl_alertas 
		          where dbo.tbl_alertas.Referencia = @Referencia)
			update dbo.tbl_alertas
			set idEstatusAlertas = 2
			where dbo.tbl_alertas.Referencia = @Referencia
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [stu_CargaDataGridProveedores]
as
	begin
		select *
		from dbo.tbl_clientesProveedores
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--INSERTA ALERTA
create procedure [spu_insertaProveedor]
(
	@idTipoIdentificacion int,
	@identificacion varchar(15),
	@nombre varchar(50),
	@direccion varchar(250),
	@telefono varchar(15),
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_clientesProveedores
		values (@idTipoIdentificacion,
				@identificacion,
				@nombre,
				@direccion,
				@telefono,
				@isDeleted)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--INSERTA ALERTA
create procedure [spu_insertaSolicitudOrden]
(
	@idTicket int,
	@detalleOrden varchar(250),
	@fechaSolicitud date,
	@isAproved bit,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_solicitudOrdenDeCompra
		values (@idTicket,
				@detalleOrden,
				@fechaSolicitud,
				@isAproved,
				@isDeleted)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
--INSERTA ALERTA
create procedure [spu_insertaOrdenDeCompra]
(
	@idTicket int,
	@idProveedor int,
	@numeroCotizacion int,
	@detalle varchar(250),
	@monto int,
	@idArchivoAdjunto int,
	@isDeleted bit
)
as
	begin
		insert into dbo.tbl_ordenCompras
		values (@idTicket,
				@idProveedor,
				@numeroCotizacion,
				@detalle,
				@monto,
				@idArchivoAdjunto,
				@isDeleted)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridSolicitudesDeCompra]
as
	begin
		select * 
		from dbo.tbl_solicitudOrdenDeCompra
		where isAproved = 0
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridOrdenesDeCompra]
as
	begin
		select idOrdenCompra,
			   idTicket,
			   nombre,
			   numeroCotizacion,
			   detalle,
			   monto
		from dbo.tbl_ordenCompras
			 left outer join dbo.tbl_clientesProveedores on dbo.tbl_ordenCompras.idProveedor = dbo.tbl_clientesProveedores.idProveedor
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridSolicitudesDeCompraDeTicketEspecifico]
(
	@idTicket int
)
as
	begin
		select * 
		from dbo.tbl_solicitudOrdenDeCompra
		where idTicket = @idTicket
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaIdTicketConIdSolicitud]
(
	@idSolicitud int
)
as
	begin
		select idTicket
		from dbo.tbl_solicitudOrdenDeCompra
		where idSolicitud = @idSolicitud
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_existeTicketParaOrdenCompra]
(
	@idTicket int
)
as
	begin
		declare @validacion bit
		set @validacion = 1
		if exists(select *
				  from dbo.tbl_tickets
				  where idTicket = @idTicket)
			select @validacion as validacion
		else
			begin
				set @validacion = 0
				select @validacion as validacion
			end
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_actualizarEstadoSolicitudDeCompra]
(
	@idSolicitud int
)
as
	begin
		update dbo.tbl_solicitudOrdenDeCompra
		set isAproved = 1
		where idSolicitud = @idSolicitud
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaListaClientes]
as
	begin
		select idClienteUsuarioFinal,
			   dbo.tbl_clientesUsuarioFinal.nombre +' '+apellidos as nombre,
			   dbo.tbl_clientesUsuarioFinal.identificacion,
			   dbo.tbl_clientesUsuarioFinal.telefonoEmpresa,
			   idEmpresaCliente
		from dbo.tbl_clientesUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaInfoEmpresasClientes]
(
	@idEmpresaCliente int
)
as
	begin
		select *
		from dbo.tbl_empresasClientes
		where idEmpresaCliente = @idEmpresaCliente
	end 
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridTicketsParaFacturas]
(
	@idClienteUsuarioFinal int
)
as
	begin
		select idTicket,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as idTipoServicio,
			   fechaRegistro,
			   dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   fechaEntrega
		from dbo.tbl_tickets
		left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
		left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
		left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
		where dbo.tbl_tickets.idEstatusTickets = 5 and
			  dbo.tbl_tickets.isCanceled = 0 and
			  idClienteUsuarioFinal = @idClienteUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridTicketsParaFacturasPorFechas]
(
	@idClienteUsuarioFinal int,
	@fechaDesde date,
	@fechahasta date
)
as
	begin
		select idTicket,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as idTipoServicio,
			   fechaRegistro,
			   dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   fechaEntrega
		from dbo.tbl_tickets
		left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
		left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
		left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
		where dbo.tbl_tickets.idEstatusTickets = 5 and
			  dbo.tbl_tickets.isCanceled = 0 and
			  idClienteUsuarioFinal = @idClienteUsuarioFinal and  
		fechaEntrega between @fechaDesde and @fechahasta
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridOrdenesDeCompraPorFactura]
(
	@idClienteUsuarioFinal int
)
as
	begin
		select idOrdenCompra,
			   idTicket,
			   dbo.tbl_clientesProveedores.nombre as idProveedor,
			   numeroCotizacion,
			   detalle,
			   monto
		from dbo.tbl_ordenCompras
		left outer join dbo.tbl_clientesProveedores on dbo.tbl_ordenCompras.idProveedor = dbo.tbl_clientesProveedores.idProveedor
		where idTicket in (select idTicket
						    from dbo.tbl_tickets
						   where dbo.tbl_tickets.idEstatusTickets = 5 and
							     dbo.tbl_tickets.isCanceled = 0 and
								 idClienteUsuarioFinal = @idClienteUsuarioFinal)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridTicketsParaFacturasConIdFactura]
(
	@idFactura int
)
as
	begin
		select idTicket,
			   titulo,
			   dbo.tbl_tipoServicio.descripcion as idTipoServicio,
			   fechaRegistro,
			   dbo.tbl_estatusTickets.descripcion as idEstatusTickets,
			   dbo.tbl_tipoPrioridades.descripcion as idPrioridad,
			   fechaEntrega
		from dbo.tbl_tickets
		left outer join dbo.tbl_tipoServicio on dbo.tbl_tickets.idTipoServicio = dbo.tbl_tipoServicio.idTipoServicio
		left outer join dbo.tbl_estatusTickets on dbo.tbl_tickets.idEstatusTickets = dbo.tbl_estatusTickets.idEstatusTickets
		left outer join dbo.tbl_tipoPrioridades on dbo.tbl_tickets.idPrioridad = dbo.tbl_tipoPrioridades.idPrioridad
		where idFactura = @idFactura
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargaDataGridOrdenesDeCompraPorFacturaPorIdFactura]
(
	@idFactura int
)
as
	begin
		select idOrdenCompra,
			   idTicket,
			   dbo.tbl_clientesProveedores.nombre as idProveedor,
			   numeroCotizacion,
			   detalle,
			   monto
		from dbo.tbl_ordenCompras
		left outer join dbo.tbl_clientesProveedores on dbo.tbl_ordenCompras.idProveedor = dbo.tbl_clientesProveedores.idProveedor
		where idTicket in (select idTicket
						    from dbo.tbl_tickets
						   where idFactura = @idFactura)
	end
go

create procedure [spu_cargaDataGridOrdenesDeCompraPorFacturaPorFecha]
(
	@idClienteUsuarioFinal int,
	@fechaDesde date,
	@fechahasta date
)
as
	begin
		select idOrdenCompra,
			   idTicket,
			   dbo.tbl_clientesProveedores.nombre as idProveedor,
			   numeroCotizacion,
			   detalle,
			   monto
		from dbo.tbl_ordenCompras
		left outer join dbo.tbl_clientesProveedores on dbo.tbl_ordenCompras.idProveedor = dbo.tbl_clientesProveedores.idProveedor
		where idTicket in (select idTicket
						    from dbo.tbl_tickets
						   where dbo.tbl_tickets.idEstatusTickets = 5 and
							     dbo.tbl_tickets.isCanceled = 0 and
								 idClienteUsuarioFinal = @idClienteUsuarioFinal and
								 fechaEntrega between @fechaDesde and @fechahasta)
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [dbo].[spu_cargaRolUsuario]
(
 @nombreUsuario varchar(10)
)
as
	begin
		select idRol as Id_Rol 
		from [db_soportic].[dbo].[tbl_usuariosSistema]
		where nombreUsuarioSistema = @nombreUsuario
	end
GO

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_insertaFactura]
(
	@idClienteUsuarioFinal int,
	@telefono varchar(15),
	@direccion varchar(250),
	@fechaDesde date,
	@fechahasta date,
	@cantidadTickets int,
	@cantidadOrdenes int,
	@cargoPorTipoServicio float,
	@cargoPorPrioridad float,
	@cargoPorPuntualidad float,
	@montoTickets float,
	@montoOrdenesCompra float,
	@subTotal int,
	@impuesto float,
	@total float
)
as
	begin
		insert into dbo.tbl_facturas
		values(@idClienteUsuarioFinal,
			   @telefono,
			   @direccion,
			   getdate(),
			   @fechaDesde,
			   @fechahasta,
			   @cantidadTickets,
			   @cantidadOrdenes,
			   @cargoPorTipoServicio,
			   @cargoPorPrioridad,
			   @cargoPorPuntualidad,
			   @montoTickets,
			   @montoOrdenesCompra,
			   @subTotal,
			   @impuesto,
			   @total,
			   0,
			   0
			   )
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargarDataGridFacturasTodas]
as
	begin
		select idFactura,
			   nombre +' '+ apellidos as idClienteUsuarioFinal,
			   fechaFactura,
			   fechaDesde,
			   fechahasta,
			   montoTickets,
			   montoOrdenesCompra,
			   subTotal,
			   impuesto,
			   total
		from dbo.tbl_facturas
		left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_facturas.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargarDataGridFacturasPendientesPago]
as
	begin
		select idFactura,
			   nombre +' '+ apellidos as idClienteUsuarioFinal,
			   fechaFactura,
			   fechaDesde,
			   fechahasta,
			   montoTickets,
			   montoOrdenesCompra,
			   subTotal,
			   impuesto,
			   total
		from dbo.tbl_facturas
		left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_facturas.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
		where isCanceled = 0
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
------------------------------------------
create procedure [spu_cargarDataGridFacturasCanceladas]
as
	begin
		select idFactura,
			   nombre +' '+ apellidos as idClienteUsuarioFinal,
			   fechaFactura,
			   fechaDesde,
			   fechahasta,
			   montoTickets,
			   montoOrdenesCompra,
			   subTotal,
			   impuesto,
			   total
		from dbo.tbl_facturas
		left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_facturas.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
		where isCanceled = 1
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
-------------------------------------------------------------
create procedure [stu_actualizarTicketsRespuestaNuevaFactura]
(
	@idTicket int,
	@idFactura int
)
as
	begin
		update dbo.tbl_tickets
		set idFactura = @idFactura,
			isCanceled = 1
		where idTicket = @idTicket
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [stp_cargaIdFacturaRecienGuardado]
as
	begin
		select idFactura
		from dbo.tbl_facturas
		where idFactura = IDENT_CURRENT('dbo.tbl_facturas')
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [stp_cargaDatosFactura]
(
	@idFactura int
)
as
	begin
		select idFactura,
			   dbo.tbl_clientesUsuarioFinal.nombre +' '+ apellidos as idClienteUsuarioFinal,
			   telefono,
			   dbo.tbl_facturas.direccion,
			   fechaFactura,
			   fechaDesde,
			   fechahasta,
			   cantidadTickets,
			   cantidadOrdenes,
			   cargoPorTipoServicio,
			   cargoPorPrioridad,
			   cargoPorPuntualidad,
			   montoTickets,
			   montoOrdenesCompra,
			   subTotal,
			   impuesto,
			   total,
			   isCanceled,
			   dbo.tbl_empresasClientes.nombre as nombreEmpresa
		from dbo.tbl_facturas
			 left outer join dbo.tbl_clientesUsuarioFinal on dbo.tbl_facturas.idClienteUsuarioFinal = dbo.tbl_clientesUsuarioFinal.idClienteUsuarioFinal
			 left outer join dbo.tbl_empresasClientes on dbo.tbl_clientesUsuarioFinal.idEmpresaCliente = dbo.tbl_empresasClientes.idEmpresaCliente
		where idFactura = @idFactura
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_actualizaEstadoDePagoFactura]
(
	@idFactura int
)
as
	begin
		update dbo.tbl_facturas
		set isCanceled = 1
		where idFactura = @idFactura
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_cargaFacturasParaEstadosDeCuenta]
(
	@idClienteUsuarioFinal int,
	@fechaDesde date,
	@fechahasta date
)
as
	begin
		select *
		from dbo.tbl_facturas
		where idClienteUsuarioFinal = @idClienteUsuarioFinal and
			  isCanceled = 1 and
		      fechaFactura between @fechaDesde and @fechahasta
	end
go

--------RAFAEL SEQUEIRA VARGAS------------
----------------Procedure -------------------------------------------------
create procedure [spu_cargaMontoTotalEstadoDeCuenta]
(
	@idClienteUsuarioFinal int,
	@fechaDesde date,
	@fechahasta date
)
as
	begin
		select SUM(total) as MontoTotal
		from dbo.tbl_facturas
		where idClienteUsuarioFinal = @idClienteUsuarioFinal and
			  isCanceled = 1 and
		      fechaFactura between @fechaDesde and @fechahasta
	end
go

-----------------RAFAEL SEQUEIRA VARGAS-------------------
----------------Procedure Existe Alerta--------------
create procedure [spu_existAlertaSobreReferencia]
(
	@Referencia int
)
as
	begin
		if exists(select * 
				  from dbo.tbl_alertas
				  where Referencia = @Referencia)
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
-------------------------------------------------------------
create procedure [spu_TicketsVencidosParaAlertas]
as
	begin
		declare @fechaHoy date
		set @fechaHoy = GETDATE()
	
		select idTicket,
			   idPrioridad,
			   dbo.tbl_empleados.nombre +' '+ dbo.tbl_empleados.apellido as idEmpleado
		from dbo.tbl_tickets
		left outer join dbo.tbl_empleados on dbo.tbl_tickets.idEmpleado = dbo.tbl_empleados.idEmpleado
		where fechaEntrega < @fechaHoy 		
	end
go