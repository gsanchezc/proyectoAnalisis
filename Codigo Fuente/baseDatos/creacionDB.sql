USE master
GO
-------------------------------------------------------------------------
------------CREACION DE LA BASE DE DATOS---------------------------------
CREATE DATABASE db_soportic
GO
USE [db_soportic]
GO
-----------------------LOGIN DB---------------------------------------------
USE [master]
GO
CREATE LOGIN [udb_soportic] WITH PASSWORD=N'123', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
USE [db_soportic]
GO
CREATE USER [udb_soportic] FOR LOGIN [udb_soportic]
GO
USE [db_soportic]
GO
ALTER USER [udb_soportic] WITH DEFAULT_SCHEMA=[dbo]
GO
USE [db_soportic]
GO
EXEC sp_addrolemember N'db_owner', N'udb_soportic'
GO
----------------------------CREACION DE LA ESTRUCTURAS DE DATOS---------------
USE master
GO

-------TABLA TIPOS DE ID------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_tipoIdentificaciones
(
	idTipoIdentificacion INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT DEFAULT(0)
	
	CONSTRAINT pk_idTipoIdentificacion PRIMARY KEY CLUSTERED
	(
		idTipoIdentificacion ASC
	)
)

GO
-------TABLA PUESTOS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_tipoPuestos
(
	idPuesto INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idPuesto PRIMARY KEY CLUSTERED
	(
		idPuesto ASC
	)
)

GO
-------TABLA DEPARTAMENTOS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_Departamentos
(
	idDepartamento INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idDepartamento PRIMARY KEY CLUSTERED
	(
		idDepartamento ASC
	)
)

GO	
-------TABLA ROLES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_descripcionRoles
(
	idRol INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idRol PRIMARY KEY CLUSTERED
	(
		idRol ASC
	)
)

GO
-------TABLA ARCHIVOS ADJUNTOS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_datosAdjuntos
(
	idArchivoAdjunto INT NOT NULL IDENTITY (1,1),
	archivo VARBINARY(MAX) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idArchivoAdjunto PRIMARY KEY CLUSTERED
	(
		idArchivoAdjunto ASC
	)
)

GO
-------TABLA STATUS TICKETS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_estatusTickets
(
	idEstatusTickets INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEstatusTickets PRIMARY KEY CLUSTERED
	(
		idEstatusTickets ASC
	)
)
-------TABLA STATUS TICKETS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_estatusAlertas
(
	idEstatusAlertas INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEstatusAlertas PRIMARY KEY CLUSTERED
	(
		idEstatusAlertas ASC
	)
)

GO

-------TABLA TIPO SERVICIO------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_tipoServicio
(
	idTipoServicio INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idTipoServicio PRIMARY KEY CLUSTERED
	(
		idTipoServicio ASC
	)
)

GO
-------TABLA SALARIOS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_salarios
(
	idSalario INT NOT NULL IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	monto DECIMAL(18,2) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idSalario PRIMARY KEY CLUSTERED
	(
		idSalario ASC
	)
)
GO

-------TABLA PRIORIDADES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_tipoPrioridades
(
	idPrioridad INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idPrioridad PRIMARY KEY CLUSTERED
	(
		idPrioridad ASC
	)
)

GO
-------TABLA TIPO ALERTAS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_TipoAlertas
(
	idTipoAlerta INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idTipoAlerta PRIMARY KEY CLUSTERED
	(
		idTipoAlerta ASC
	)
)

GO
-------TABLA EMPRESAS CLIENTES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_empresasClientes
(
	idEmpresaCliente INT NOT NULL IDENTITY(1,1),
	nombre VARCHAR(50) NOT NULL,
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	telefonoEmpresa VARCHAR(15) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEmpresaCliente PRIMARY KEY CLUSTERED
	(
		idEmpresaCliente ASC
	)
)

GO
-------TABLA CLIENTES USUARIO FINAL------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_clientesUsuarioFinal
(
	idClienteUsuarioFinal INT NOT NULL IDENTITY (1,1),
	idUsuarioSistema INT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellidos VARCHAR(50) NOT NULL,
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	telefonoEmpresa VARCHAR(15) NULL,
	idEmpresaCliente INT NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idClienteUsuarioFinal PRIMARY KEY CLUSTERED
	(
		idClienteUsuarioFinal ASC
	)
)

GO
-------TABLA EMPLEADOS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_empleados
(
	idEmpleado INT NOT NULL IDENTITY (1,1),
	idUsuarioSistema INT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	fechaNacimiento DATETIME NOT NULL,
	correo VARCHAR(50) NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	idDepartamento INT NOT NULL,
	idPuesto INT NOT NULL,
	telefono VARCHAR(15) NULL,
	celular VARCHAR(15) NULL,
	fechaIngreso DATETIME NOT NULL,	
	vacacionesDisponibles INT NOT NULL DEFAULT(0),
	idSalario INT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEmpleado PRIMARY KEY CLUSTERED
	(
		idEmpleado ASC
	)
)

GO
-------TABLA USUARIOS SISTEMA------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_usuariosSistema
(
	idUsuarioSistema INT NOT NULL IDENTITY(1,1),
	nombreUsuarioSistema VARCHAR(10) NOT NULL UNIQUE,
	contrasenna VARCHAR(200) NOT NULL,
	idRol INT NOT NULL,
	isBlocked BIT NOT NULL DEFAULT(0),
	isdeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_nombreUsuarioSistema PRIMARY KEY CLUSTERED
	(
		idUsuarioSistema ASC
	)
)

GO
-------TABLA TICKETS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_tickets
(
	idTicket INT NOT NULL IDENTITY (1,1),
	idClienteUsuarioFinal INT NOT NULL,
	idDepartamento INT NOT NULL,
	titulo VARCHAR(200) NOT NULL,
	idTipoServicio INT NOT NULL,
	descripcion VARCHAR(MAX) NOT NULL,
	idArchivoAdjunto INT NULL,
	fechaRegistro DATE NOT NULL,
	idEstatusTickets INT NOT NULL DEFAULT(0),
	idPrioridad INT NULL,
	idEmpleado INT NULL,
	fechaAsignacion DATE NULL,
	fechaInicio DATE NULL,
	fechaEntrega DATE NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idTicket PRIMARY KEY CLUSTERED
	(
		idTicket ASC
	)
)

GO
-------TABLA BITACORA------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_bitacoras
(
	idBitacora INT NOT NULL IDENTITY (1,1),
	idTicket INT NOT NULL,
	tiempoLaborado INT NOT NULL,
	descripcion VARCHAR(MAX) NOT NULL,
	idArchivoAdjunto INT NULL,	
	fecha DATE NOT NULL,
	idEmpleado INT NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)	
	
	CONSTRAINT pk_idBitacora PRIMARY KEY CLUSTERED
	(
		idBitacora ASC
	)
)

GO
-------TABLA VACACIONES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_vacaciones
(
	idSolicitudVacacion INT NOT NULL IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFin DATE NOT NULL,
	diasSolicitados INT NOT NULL,
	idAprobacionVacacion INT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)

	CONSTRAINT pk_idSolicitudVacacion PRIMARY KEY CLUSTERED
	(
		idSolicitudVacacion ASC
	)
)

GO
-------TABLA INCAPACIDADES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_incapacidades
(
	idIncapacidad INT NOT NULL IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	diaInicio DATE NOT NULL,
	diaFin DATE NOT NULL,
	totalDias INT NOT NULL,
	isApprove BIT NOT NULL DEFAULT(0),
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idIncapacidad PRIMARY KEY CLUSTERED
	(
		idIncapacidad ASC
	)
)

GO
-------TABLA PROVEEDORES------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_clientesProveedores
(
	idProveedor INT NOT NULL IDENTITY (1,1),
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	telefono VARCHAR(15) NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idProveedor PRIMARY KEY CLUSTERED
	(
		idProveedor ASC
	)
)

GO
-------TABLA ORDENES DE COMPRA------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_ordenCompras
(
	idOrdenCompra INT NOT NULL IDENTITY (1,1),
	idTicket INT NOT NULL,
	idProveedor INT NOT NULL,
	numeroCotizacion INT NOT NULL,
	detalle VARCHAR(250) NOT NULL,
	monto INT NOT NULL,
	idArchivoAdjunto INT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idOrdenCompra PRIMARY KEY CLUSTERED
	(
		idOrdenCompra ASC
	)
)

GO
-------TABLA FACTURAS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_facturas
(
	idFactura INT NOT NULL IDENTITY (1,1),
	idClienteUsuarioFinal INT NOT NULL,
	telefono VARCHAR(15) NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	fechaFactura DATE NOT NULL,
	fechaDesde DATE NOT NULL,
	fechahasta DATE NOT NULL,
	detalle VARCHAR(250) NOT NULL,
	subTotal INT NOT NULL,
	impuesto INT NULL,
	total INT NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idFactura PRIMARY KEY CLUSTERED
	(
		idFactura ASC
	)
)

GO
-------TABLA ALERTAS------------------------------------------------------
CREATE TABLE db_soportic.dbo.tbl_alertas
(
	idAlerta INT NOT NULL IDENTITY (1,1),
	idTipoAlerta INT NOT NULL,
	detalle VARCHAR(250) NOT NULL,
	idEmpleado INT NOT NULL,
	fechaSuceso DATETIME,
	fechaFinalizacion DATETIME,
	idPrioridad INT NOT NULL,
	idEstatusAlertas INT NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idAlerta  PRIMARY KEY CLUSTERED
	(
		idAlerta  ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_vacacionesAprobadas
(
	idAprobacionVacacion INT NOT NULL IDENTITY(1,1),
	idSupervisor INT NOT NULL,
	fechaAprobacion DATE NOT NULL
	
	CONSTRAINT pk_idAprobacionVacacion PRIMARY KEY CLUSTERED
	(
		idAprobacionVacacion ASC
	)
)
GO
--Creacion de llave foranea en la tabla vacaciones
ALTER TABLE db_soportic.dbo.tbl_vacaciones
WITH NOCHECK ADD CONSTRAINT fk_vacacionesAprobadas_vacaciones
FOREIGN KEY (idAprobacionVacacion)
REFERENCES db_soportic.dbo.tbl_vacacionesAprobadas(idAprobacionVacacion)
GO

ALTER TABLE db_soportic.dbo.tbl_vacaciones
CHECK CONSTRAINT fk_vacacionesAprobadas_vacaciones
GO

--Creacion de llave Foranea en la tabla Empresas Clientes
ALTER TABLE db_soportic.dbo.tbl_vacacionesAprobadas
WITH NOCHECK ADD CONSTRAINT fk_empleados_vacacionesAprobadas
FOREIGN KEY (idSupervisor)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_vacacionesAprobadas
CHECK CONSTRAINT fk_empleados_vacacionesAprobadas
GO

--Creacion de llave Foranea en la tabla Empresas Clientes
ALTER TABLE db_soportic.dbo.tbl_empresasClientes
WITH NOCHECK ADD CONSTRAINT fk_tipoIdentificaciones_empresasClientes
FOREIGN KEY (idTipoIdentificacion)
REFERENCES db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO
Alter Table db_soportic.dbo.tbl_empresasClientes
Check Constraint [fk_tipoIdentificaciones_empresasClientes]
GO

--Creacion de llave Foranea en la tabla Clientes Usuario Final
ALTER TABLE db_soportic.dbo.tbl_clientesUsuarioFinal
WITH NOCHECK ADD CONSTRAINT fk_TipoIdentificacion_clientesUsuarioFinal
FOREIGN KEY (idTipoIdentificacion)
REFERENCES db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO
Alter Table db_soportic.dbo.tbl_clientesUsuarioFinal
Check Constraint [fk_TipoIdentificacion_clientesUsuarioFinal]
GO

--Creacion de llave Foranea en la tabla Clientes Usuario Final
ALTER TABLE db_soportic.dbo.tbl_clientesUsuarioFinal
WITH NOCHECK ADD CONSTRAINT fk_empresasClientes_clientesUsuarioFinal
FOREIGN KEY (idEmpresaCliente)
REFERENCES db_soportic.dbo.tbl_empresasClientes(idEmpresaCliente)
GO
Alter Table db_soportic.dbo.tbl_clientesUsuarioFinal
Check Constraint [fk_empresasClientes_clientesUsuarioFinal]
GO

--Creacion de llave Foranea en la tabla Clientes Usuario Final
ALTER TABLE db_soportic.dbo.tbl_clientesUsuarioFinal
WITH NOCHECK ADD CONSTRAINT fk_clientesUsuarioFinal_usuariosSistema
FOREIGN KEY (idUsuarioSistema)
REFERENCES db_soportic.dbo.tbl_usuariosSistema
GO
ALTER TABLE db_soportic.dbo.tbl_clientesUsuarioFinal
CHECK CONSTRAINT [fk_clientesUsuarioFinal_usuariosSistema]
GO

--Creacion de llave Foranea en la tabla Empleados
ALTER TABLE db_soportic.dbo.tbl_empleados
WITH NOCHECK ADD CONSTRAINT fk_TipoIdentificacion_empleados
FOREIGN KEY (idTipoIdentificacion)
REFERENCES db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO
Alter Table db_soportic.dbo.tbl_empleados
Check Constraint [fk_TipoIdentificacion_empleados]
GO

--Creacion de llave Foranea en la tabla Empleados
ALTER TABLE db_soportic.dbo.tbl_empleados
WITH NOCHECK ADD CONSTRAINT fk_Departamentos_empleados
FOREIGN KEY (idDepartamento)
REFERENCES db_soportic.dbo.tbl_Departamentos(idDepartamento)
GO
Alter Table db_soportic.dbo.tbl_empleados
Check Constraint [fk_Departamentos_empleados]
GO

--Creacion de llave Foranea en la tabla Empleados
ALTER TABLE db_soportic.dbo.tbl_empleados
WITH NOCHECK ADD CONSTRAINT fk_tipoPuestos_empleados
FOREIGN KEY (idPuesto)
REFERENCES db_soportic.dbo.tbl_tipoPuestos(idPuesto)
GO
Alter Table db_soportic.dbo.tbl_empleados
Check Constraint [fk_tipoPuestos_empleados]
GO

--Creacion de llave Foranea en la tabla Empleados
ALTER TABLE db_soportic.dbo.tbl_empleados
WITH NOCHECK ADD CONSTRAINT fk_salarios_empleados
FOREIGN KEY (idSalario)
REFERENCES db_soportic.dbo.tbl_salarios(idSalario)
GO
Alter Table db_soportic.dbo.tbl_empleados
Check Constraint [fk_salarios_empleados]
GO

--Creacion de llave Foranea en la tabla Empleados
ALTER TABLE db_soportic.dbo.tbl_empleados
WITH NOCHECK ADD CONSTRAINT fk_usuariosSistema_empleados
FOREIGN KEY (idUsuarioSistema)
REFERENCES db_soportic.dbo.tbl_usuariosSistema
GO
ALTER TABLE db_soportic.dbo.tbl_empleados
CHECK CONSTRAINT [fk_usuariosSistema_empleados]
GO

--Creacion de llave Foranea en la tabla USUARIOS SISTEMA
ALTER TABLE db_soportic.dbo.tbl_usuariosSistema
WITH NOCHECK ADD CONSTRAINT fk_Rol_usuariosSistema
FOREIGN KEY (idRol)
REFERENCES db_soportic.dbo.tbl_descripcionRoles(idRol)
GO
Alter Table db_soportic.dbo.tbl_usuariosSistema
Check Constraint [fk_Rol_usuariosSistema]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_clientesUsuarioFinal_tickets
FOREIGN KEY (idClienteUsuarioFinal)
REFERENCES db_soportic.dbo.tbl_clientesUsuarioFinal(idClienteUsuarioFinal)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_clientesUsuarioFinal_tickets]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_Departamentos_tickets
FOREIGN KEY (idDepartamento)
REFERENCES db_soportic.dbo.tbl_Departamentos(idDepartamento)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_Departamentos_tickets]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_tipoServicio_tickets
FOREIGN KEY (idTipoServicio)
REFERENCES db_soportic.dbo.tbl_tipoServicio(idTipoServicio)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_tipoServicio_tickets]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_EstatusTickets_tickets
FOREIGN KEY (idEstatusTickets)
REFERENCES db_soportic.dbo.tbl_estatusTickets(idEstatusTickets)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_EstatusTickets_tickets]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_tipoPrioridades_tickets
FOREIGN KEY (idPrioridad)
REFERENCES db_soportic.dbo.tbl_tipoPrioridades(idPrioridad)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_tipoPrioridades_tickets]
GO

--Creacion de llave Foranea en la tabla TICKETS
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_empleados_tickets
FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO
Alter Table db_soportic.dbo.tbl_tickets
Check Constraint [fk_empleados_tickets]
GO

--Creacion de llave Foranea en la tabla BITACORA
ALTER TABLE db_soportic.dbo.tbl_bitacoras
WITH NOCHECK ADD CONSTRAINT fk_tickets_bitacoras
FOREIGN KEY (idTicket)
REFERENCES db_soportic.dbo.tbl_tickets(idTicket)
GO
Alter Table db_soportic.dbo.tbl_bitacoras
Check Constraint [fk_tickets_bitacoras]
GO


--Creacion de llave Foranea en la tabla BITACORA
ALTER TABLE db_soportic.dbo.tbl_bitacoras
WITH NOCHECK ADD CONSTRAINT fk_empleados_bitacoras
FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO
Alter Table db_soportic.dbo.tbl_bitacoras
Check Constraint [fk_empleados_bitacoras]
GO

--Creacion de llave Foranea en la tabla VACACIONES
ALTER TABLE db_soportic.dbo.tbl_vacaciones
WITH NOCHECK ADD CONSTRAINT fk_empleados_vacaciones
FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO
Alter Table db_soportic.dbo.tbl_vacaciones
Check Constraint [fk_empleados_vacaciones]
GO

--Creacion de llave Foranea en la tabla INCAPACIDADES
ALTER TABLE db_soportic.dbo.tbl_incapacidades
WITH NOCHECK ADD CONSTRAINT fk_empleados_incapacidades
FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO
Alter Table db_soportic.dbo.tbl_incapacidades
Check Constraint [fk_empleados_incapacidades]
GO

--Creacion de llave Foranea en la tabla PROVEEDORES
ALTER TABLE db_soportic.dbo.tbl_clientesProveedores
WITH NOCHECK ADD CONSTRAINT fk_tipoIdentificaciones_clientesProveedores
FOREIGN KEY (idTipoIdentificacion)
REFERENCES db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO
Alter Table db_soportic.dbo.tbl_clientesProveedores
Check Constraint [fk_tipoIdentificaciones_clientesProveedores]
GO

--Creacion de llave Foranea en la tabla ORDENES DE COMPRA
ALTER TABLE db_soportic.dbo.tbl_ordenCompras
WITH NOCHECK ADD CONSTRAINT fk_tickets_ordenCompras
FOREIGN KEY (idTicket)
REFERENCES db_soportic.dbo.tbl_tickets(idTicket)
GO
Alter Table db_soportic.dbo.tbl_ordenCompras
Check Constraint [fk_tickets_ordenCompras]
GO

--Creacion de llave Foranea en la tabla ORDENES DE COMPRA
ALTER TABLE db_soportic.dbo.tbl_ordenCompras
WITH NOCHECK ADD CONSTRAINT fk_clientesProveedores_ordenCompras
FOREIGN KEY (idProveedor)
REFERENCES db_soportic.dbo.tbl_clientesProveedores(idProveedor)
GO
Alter Table db_soportic.dbo.tbl_ordenCompras
Check Constraint [fk_clientesProveedores_ordenCompras]
GO

--Creacion de llave Foranea en la tabla FACTURAS
ALTER TABLE db_soportic.dbo.tbl_facturas
WITH NOCHECK ADD CONSTRAINT fk_clientesUsuarioFinal_facturas
FOREIGN KEY (idClienteUsuarioFinal)
REFERENCES db_soportic.dbo.tbl_clientesUsuarioFinal(idClienteUsuarioFinal)
GO
Alter Table db_soportic.dbo.tbl_facturas
Check Constraint [fk_clientesUsuarioFinal_facturas]
GO

--Creacion de llave Foranea en la tabla ALERTAS
ALTER TABLE db_soportic.dbo.tbl_alertas
WITH NOCHECK ADD CONSTRAINT fk_TipoAlertas_alertas
FOREIGN KEY (idTipoAlerta)
REFERENCES db_soportic.dbo.tbl_TipoAlertas(idTipoAlerta)
GO
Alter Table db_soportic.dbo.tbl_alertas
Check Constraint [fk_TipoAlertas_alertas]
GO

--Creacion de llave Foranea en la tabla ALERTAS
ALTER TABLE db_soportic.dbo.tbl_alertas
WITH NOCHECK ADD CONSTRAINT fk_empleados_alertas
FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO
Alter Table db_soportic.dbo.tbl_alertas
Check Constraint [fk_empleados_alertas]
GO

--Creacion de llave Foranea en la tabla ALERTAS
ALTER TABLE db_soportic.dbo.tbl_alertas
WITH NOCHECK ADD CONSTRAINT fk_tipoPrioridades_alertas
FOREIGN KEY (idPrioridad)
REFERENCES db_soportic.dbo.tbl_tipoPrioridades(idPrioridad)
GO
Alter Table db_soportic.dbo.tbl_alertas
Check Constraint [fk_tipoPrioridades_alertas]
GO

--Creacion de llave Foranea en la tabla ALERTAS
ALTER TABLE db_soportic.dbo.tbl_alertas
WITH NOCHECK ADD CONSTRAINT fk_estatusAlertas_alertas
FOREIGN KEY (idEstatusAlertas)
REFERENCES db_soportic.dbo.tbl_estatusAlertas(idEstatusAlertas)
GO
Alter Table db_soportic.dbo.tbl_alertas
Check Constraint [fk_estatusAlertas_alertas]
GO

--Creacion de llave Foranea en la tabla BITACORAS
ALTER TABLE db_soportic.dbo.tbl_bitacoras
WITH NOCHECK ADD CONSTRAINT fk_bitacoras_datosAdjuntos
FOREIGN KEY (idArchivoAdjunto)
REFERENCES db_soportic.dbo.tbl_datosAdjuntos(idArchivoAdjunto)
GO
ALTER TABLE db_soportic.dbo.tbl_bitacoras
CHECK CONSTRAINT [fk_bitacoras_datosAdjuntos]
GO

--creacion de llave foranea en la tabla tickets
ALTER TABLE db_soportic.dbo.tbl_tickets
WITH NOCHECK ADD CONSTRAINT fk_tickets_datosAdjuntos
FOREIGN KEY (idArchivoAdjunto)
REFERENCES db_soportic.dbo.tbl_datosAdjuntos(idArchivoAdjunto)
GO
ALTER TABLE db_soportic.dbo.tbl_tickets
CHECK CONSTRAINT [fk_tickets_datosAdjuntos]
GO



