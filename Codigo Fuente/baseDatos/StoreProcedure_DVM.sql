----------------------------------------------------------------------------------------
--------------Store Procedure anteriores no respaldados-----------------------------
--------------Procedure que trae la Descripcion de Departamentos-----------------
alter procedure stp_traeDescripcionDepartamentos

as
begin
	select idDepartamento, descripcion 
	from tbl_Departamentos where isDeleted=0
end

go

----------------Procedure de borrado Descripcion Depatamentos------------------------------
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

---------Procedure que sólo trae datos de la tabla tbl_tipoClienteProveedor---------------
alter procedure stp_traeTipoClienteProveedor

as
begin
		select idProveedor, descripcion 
		from db_soportic.dbo.tbl_clientesProveedores where isDeleted=0
end
go

-------------Procedure que realiza borrado logico de un Cliente proveedor de la tabla tbl_tipoClientesProveedores------
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

--------Procedure que trae/jala la informacion de la tabla tbl_tipoIdentificacion--------
alter procedure stp_traeTipoIdentificacion
as
begin
	select *
	from tbl_tipoIdentificaciones where isDeleted=0
end
go

----------Procedure de borrado---------
alter procedure stp_borrarTipoIdentificacion
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
alter procedure stp_traeEstatusTickets
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
alter procedure stp_traeTipoPrioridad
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
---------------Procedures del 5 al 8 de noviembre-------------------------------
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

--------------procedure que trae la informacion de tipo de identificacion------------
create procedure stp_traeTipoIdentificacion
as
begin
	select *
	from tbl_tipoIdentificaciones where isDeleted=0
end
go

--------------Procedure que trae la Descripcion de Departamentos-----------------
alter procedure stp_traeDescripcionDepartamentos

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