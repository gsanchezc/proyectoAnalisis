USE master
GO

CREATE DATABASE db_soportic
GO

--USE db_soportic
--GO


CREATE TABLE db_soportic.dbo.tbl_tipoIdentificaciones
(
	idTipoIdentificacion INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idTipoIdentificacion PRIMARY KEY CLUSTERED
	(
		idTipoIdentificacion ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_tipoClientesProveedores
(
	idTipoClienteProveedor INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idTipoClienteProveedor PRIMARY KEY CLUSTERED
	(
		idTipoClienteProveedor ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_estatusFacturas
(
	idEstatus INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idEstatus PRIMARY KEY CLUSTERED
	(
		idEstatus ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_tipoPuestos
(
	idPuesto INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idPuesto PRIMARY KEY CLUSTERED
	(
		idPuesto ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_descripcionRoles
(
	idRol INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idRol PRIMARY KEY CLUSTERED
	(
		idRol ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_descripcionDepartamentos
(
	idDepartamento INT NOT NULL IDENTITY (1,1),
	descripcion VARCHAR(50)
	
	CONSTRAINT pk_idTipoDepartamento PRIMARY KEY CLUSTERED
	(
		idDepartamento ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_datosAdjuntos
(
	idArchivo INT NOT NULL IDENTITY (1,1),
	archivo VARBINARY(MAX)
	
	CONSTRAINT pk_idArchivo PRIMARY KEY CLUSTERED
	(
		idArchivo ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_clientesProveedores
(
	idCliente INT NOT NULL IDENTITY (1,1),
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	idTipoClienteProveedor INT NOT NULL,
	direccion VARCHAR(250) NOT NULL,
	telefono VARCHAR(15) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idCliente PRIMARY KEY CLUSTERED
	(
		idCliente ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_contactosClientesProveedores
(
	idContacto INT NOT NULL IDENTITY (1,1),
	idClienteProveedor INT NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	correo VARCHAR(50) NOT NULL,
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idContacto PRIMARY KEY CLUSTERED
	(
		idContacto ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_ordenCompras
(
	idOrdenCompra INT NOT NULL IDENTITY (1,1),
	idCliente INT NOT NULL,
	idFactura INT NULL,
	idSupervisor INT NOT NULL,
	idProveedor INT NOT NULL,
	idAdjunto INT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	
	CONSTRAINT pk_idOrdenCompra PRIMARY KEY CLUSTERED
	(
		idOrdenCompra ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_bitacoras
(
	idBitacora INT NOT NULL IDENTITY (1,1),
	idTicket INT NOT NULL,
	descripcion VARCHAR(MAX) NOT NULL,
	idAdjunto INT NULL,
	tiempoLaborado INT NOT NULL,
	fecha DATE NOT NULL,
	idEmpleado INT NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	
	CONSTRAINT pk_idBitacora PRIMARY KEY CLUSTERED
	(
		idBitacora ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_facturas
(
	idFactura INT NOT NULL IDENTITY (1,1),
	idCliente INT NOT NULL,
	fecha DATE NOT NULL,
	estadoFactura INT NOT NULL DEFAULT(0),
	subTotal INT NOT NULL,
	impuesto INT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idFactura PRIMARY KEY CLUSTERED
	(
		idFactura ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_tickets
(
	idTicket INT NOT NULL IDENTITY (1,1),
	idCliente INT NOT NULL,
	descripcion VARCHAR(MAX) NOT NULL,
	titulo VARCHAR(200) NOT NULL,
	idEmpleado INT NULL,
	idEstatus INT NOT NULL DEFAULT(0),
	idDepartamento INT NOT NULL,
	idAdjunto INT NULL,
	idPrioridad INT NULL,
	fechaRegistro DATE NOT NULL,
	fechaAsignacion DATE NULL,
	fechaEntrega DATE NULL
	
	CONSTRAINT pk_idTicket PRIMARY KEY CLUSTERED
	(
		idTicket ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_usuariosSistema
(
	idUsuarioSistema INT NOT NULL IDENTITY (1,1),
	idRol INT NOT NULL,
	contrasenna VARBINARY(200) NOT NULL,
	isblock BIT NOT NULL DEFAULT(0),
	idEmpleado INT NOT NULL,
	isdeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idUsuarioSistema PRIMARY KEY CLUSTERED
	(
		idUsuarioSistema ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_empleados
(
	idEmpleado INT NOT NULL IDENTITY (1,1),
	idTipoIdentificacion INT NOT NULL,
	identificacion VARCHAR(15) NOT NULL,
	nombre VARCHAR(50) NOT NULL,
	apellido VARCHAR(50) NOT NULL,
	telefono VARCHAR(15) NULL,
	celular VARCHAR(15) NULL,
	correo VARCHAR(50) NOT NULL,
	idRol INT NOT NULL,
	idDepartamento INT NOT NULL,
	idPuesto INT NOT NULL,
	vacacionesDisponibles INT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEmpleado PRIMARY KEY CLUSTERED
	(
		idEmpleado ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_incapacidades
(
	idIncapacidad INT NOT NULL IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	idSupervisor INT NOT NULL,
	diaInicio DATE NOT NULL,
	diaFin DATE NOT NULL,
	totalDias INT NOT NULL
	
	CONSTRAINT pk_idIncapacidad PRIMARY KEY CLUSTERED
	(
		idIncapacidad ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_vacaciones
(
	idSolicitudVacacion INT NOT NULL IDENTITY(1,1),
	idEmpleado INT NOT NULL,
	idSupervisor INT NOT NULL,
	isApprove BIT NOT NULL DEFAULT(0),
	diasSolicitados INT NOT NULL,
	fechaInicio DATE NOT NULL,
	fechaFin DATE NOT NULL
	
	CONSTRAINT pk_idSolicitudVacacion PRIMARY KEY CLUSTERED
	(
		idSolicitudVacacion ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_parametros
(
	idParametro INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	valor VARCHAR(15) NOT NULL
	
	CONSTRAINT pk_idParametro PRIMARY KEY CLUSTERED
	(
		idParametro ASC
	)
)
GO

CREATE TABLE db_soportic.dbo.tbl_estatusTickets
(
	idEstatus INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idEstatusTickets PRIMARY KEY CLUSTERED
	(
		idEstatus ASC
	)
)

GO

CREATE TABLE db_soportic.dbo.tbl_tipoPrioridades
(
	idPrioridad INT NOT NULL IDENTITY(1,1),
	descripcion VARCHAR(50) NOT NULL,
	isDeleted BIT NOT NULL DEFAULT(0)
	
	CONSTRAINT pk_idPrioridades PRIMARY KEY CLUSTERED
	(
		idPrioridad ASC
	)
)

GO

/*
ALTER TABLE db_soportic.dbo.tbl_ WITH CHECK ADD CONSTRAINT fk_  FOREIGN KEY()
REFERENCES  db_soportic.dbo.tbl_()
GO

ALTER TABLE db_soportic.dbo.tbl_ CHECK CONSTRAINT fk_
GO
*/

-------TABLA BITACORA----------
--Usuario de la bitácora
ALTER TABLE db_soportic.dbo.tbl_bitacoras WITH CHECK ADD CONSTRAINT fk_bitacoras_idEmpleado FOREIGN KEY (idEmpleado)
REFERENCES db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_bitacoras CHECK CONSTRAINT fk_bitacoras_idEmpleado
GO

--ticket de la bitácora
ALTER TABLE db_soportic.dbo.tbl_bitacoras WITH CHECK ADD CONSTRAINT fk_bitacoras_idTicket  FOREIGN KEY(idTicket)
REFERENCES  db_soportic.dbo.tbl_tickets(idTicket)
GO

ALTER TABLE db_soportic.dbo.tbl_bitacoras CHECK CONSTRAINT fk_bitacoras_idTicket
GO

--Adjunto de la bitácora
ALTER TABLE db_soportic.dbo.tbl_bitacoras WITH CHECK ADD CONSTRAINT FK_bitacoras_idAdjunto FOREIGN KEY(idAdjunto)
REFERENCES  db_soportic.dbo.tbl_datosAdjuntos(idArchivo)
GO

ALTER TABLE db_soportic.dbo.tbl_bitacoras CHECK CONSTRAINT fk_bitacoras_idAdjunto
GO



---------TABLA CLIENTESPROVEEDORES---------------------


--Tipo identificacion del cliente proveedor
ALTER TABLE db_soportic.dbo.tbl_clientesProveedores WITH CHECK ADD CONSTRAINT fk_clienteProveedor_idTipoIdentificacion  FOREIGN KEY(idTipoIdentificacion)
REFERENCES  db_soportic.dbo.tbl_tipoClientesProveedores(idTipoClienteProveedor)
GO

ALTER TABLE db_soportic.dbo.tbl_clientesProveedores CHECK CONSTRAINT fk_clienteproveedor_idTipoIdentificacion
GO

--Tipo de clienteProveedor
ALTER TABLE db_soportic.dbo.tbl_clientesProveedores WITH CHECK ADD CONSTRAINT fk_clienteProveedor_idTipoClienteProveedor  FOREIGN KEY(idTipoClienteProveedor)
REFERENCES  db_soportic.dbo.tbl_tipoClientesProveedores(idTipoClienteProveedor)
GO

ALTER TABLE db_soportic.dbo.tbl_clientesProveedores CHECK CONSTRAINT fk_clienteProveedor_idTipoClienteProveedor
GO


-----------TABLA CONTACTOS POR CLIENTE (contactosClientesProveedores)------------------

--id Cliente/Proveedor
ALTER TABLE db_soportic.dbo.tbl_contactosClientesProveedores WITH CHECK ADD CONSTRAINT fk_contactosClientesProveedores_idClienteProveedor  FOREIGN KEY(idClienteProveedor)
REFERENCES  db_soportic.dbo.tbl_clientesProveedores(idCliente)
GO

ALTER TABLE db_soportic.dbo.tbl_contactosClientesProveedores CHECK CONSTRAINT fk_contactosClientesProveedores_idClienteProveedor
GO

--Tipo identificacion
ALTER TABLE db_soportic.dbo.tbl_contactosClientesProveedores WITH CHECK ADD CONSTRAINT fk_contactosClientesProveedores_idTipoIdentificacion  FOREIGN KEY(idTipoIdentificacion)
REFERENCES  db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO

ALTER TABLE db_soportic.dbo.tbl_contactosClientesProveedores CHECK CONSTRAINT fk_contactosClientesProveedores_idTipoIdentificacion
GO


------------TABLA FACTURAS----------

--Cliente de la facutra
ALTER TABLE db_soportic.dbo.tbl_facturas WITH CHECK ADD CONSTRAINT fk_facturas_idCliente  FOREIGN KEY(idCliente)
REFERENCES  db_soportic.dbo.tbl_clientesProveedores(idCliente)
GO

ALTER TABLE db_soportic.dbo.tbl_facturas CHECK CONSTRAINT fk_facturas_idCliente
GO

--Estado de la factura
ALTER TABLE db_soportic.dbo.tbl_facturas WITH CHECK ADD CONSTRAINT fk_facturas_estadoFactura  FOREIGN KEY(estadoFactura)
REFERENCES  db_soportic.dbo.tbl_estatusFacturas(idEstatus)
GO

ALTER TABLE db_soportic.dbo.tbl_facturas CHECK CONSTRAINT fk_facturas_estadoFactura
GO

----------------TABLA INCAPACIDADES---------------------

--Empleado de la incapacidad
ALTER TABLE db_soportic.dbo.tbl_incapacidades WITH CHECK ADD CONSTRAINT fk_incapacidades_idEmpleado  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_incapacidades CHECK CONSTRAINT fk_incapacidades_idEmpleado
GO

--Supervisor que digito la incapacidad
ALTER TABLE db_soportic.dbo.tbl_incapacidades WITH CHECK ADD CONSTRAINT fk_incapacidades_idSupervisor  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_incapacidades CHECK CONSTRAINT fk_incapacidades_idSupervisor
GO



--------------------TABLA EMPLEADOS-----------------------------------------------------------------

--Tipo identificacion del empleado
ALTER TABLE db_soportic.dbo.tbl_empleados WITH CHECK ADD CONSTRAINT fk_empleados_idTipoIdentificacion FOREIGN KEY(idTipoIdentificacion)
REFERENCES db_soportic.dbo.tbl_tipoIdentificaciones(idTipoIdentificacion)
GO

ALTER TABLE db_soportic.dbo.tbl_empleados CHECK CONSTRAINT fk_empleados_idTipoIdentificacion
GO

--Rol del empleado
ALTER TABLE db_soportic.dbo.tbl_empleados WITH CHECK ADD CONSTRAINT fk_empleados_idRol  FOREIGN KEY(idRol)
REFERENCES  db_soportic.dbo.tbl_descripcionRoles(idRol)
GO

ALTER TABLE db_soportic.dbo.tbl_empleados CHECK CONSTRAINT fk_empleados_idRol
GO

--departamento del empleado
ALTER TABLE db_soportic.dbo.tbl_empleados WITH CHECK ADD CONSTRAINT fk_empleados_idDepartamentos  FOREIGN KEY(idDepartamento)
REFERENCES  db_soportic.dbo.tbl_descripcionDepartamentos(idDepartamento)
GO

ALTER TABLE db_soportic.dbo.tbl_empleados CHECK CONSTRAINT fk_empleados_idDepartamentos
GO

--Descripcion puesto
ALTER TABLE db_soportic.dbo.tbl_empleados WITH CHECK ADD CONSTRAINT fk_empleados_idPuesto  FOREIGN KEY(idPuesto)
REFERENCES  db_soportic.dbo.tbl_tipoPuestos(idPuesto)
GO

ALTER TABLE db_soportic.dbo.tbl_empleados CHECK CONSTRAINT fk_empleados_idPuesto
GO

-------------TABLA ORDEN DE COMPRAS---------------------

--Cliente en la orden de compra
ALTER TABLE db_soportic.dbo.tbl_ordenCompras WITH CHECK ADD CONSTRAINT fk_ordenCompras_idCliente  FOREIGN KEY(idCliente)
REFERENCES  db_soportic.dbo.tbl_clientesProveedores(idCliente)
GO

ALTER TABLE db_soportic.dbo.tbl_ordenCompras CHECK CONSTRAINT fk_ordenCompras_idCliente
GO

--Factura asociada a la orden de compra
ALTER TABLE db_soportic.dbo.tbl_ordenCompras WITH CHECK ADD CONSTRAINT fk_ordenCompras_idFacturas  FOREIGN KEY(idFactura)
REFERENCES  db_soportic.dbo.tbl_facturas(idFactura)
GO

ALTER TABLE db_soportic.dbo.tbl_ordenCompras CHECK CONSTRAINT fk_ordenCompras_idFacturas
GO

--Supervisor digitador
ALTER TABLE db_soportic.dbo.tbl_ordenCompras WITH CHECK ADD CONSTRAINT fk_ordenCompras_idSupervisor  FOREIGN KEY(idSupervisor)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_ordenCompras CHECK CONSTRAINT fk_ordenCompras_idSupervisor
GO

--Proveedor asociado
ALTER TABLE db_soportic.dbo.tbl_ordenCompras WITH CHECK ADD CONSTRAINT fk_ordenCompras_idProveedor  FOREIGN KEY(idProveedor)
REFERENCES  db_soportic.dbo.tbl_clientesProveedores(idCliente)
GO

ALTER TABLE db_soportic.dbo.tbl_ordenCompras CHECK CONSTRAINT fk_ordenCompras_idProveedor
GO

--Adjunto Asociado
ALTER TABLE db_soportic.dbo.tbl_ordenCompras WITH CHECK ADD CONSTRAINT fk_ordenCompras_idAdjunto  FOREIGN KEY(idAdjunto)
REFERENCES  db_soportic.dbo.tbl_datosAdjuntos(idArchivo)
GO

ALTER TABLE db_soportic.dbo.tbl_ordenCompras CHECK CONSTRAINT fk_ordenCompras_idAdjunto
GO

--------------------TICKETS----------------
--Cliente del ticket
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_idCliente  FOREIGN KEY(idCliente)
REFERENCES  db_soportic.dbo.tbl_clientesProveedores(idCliente)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_idCliente
GO

--Empleado asociado
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_idEmpleado  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_idEmpleado
GO

--Estatus del ticket
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_estatus  FOREIGN KEY(idEstatus)
REFERENCES  db_soportic.dbo.tbl_estatusTickets(idEstatus)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_estatus
GO

--Departamento asignado
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_idDepartamento  FOREIGN KEY(idDepartamento)
REFERENCES  db_soportic.dbo.tbl_descripcionDepartamentos(idDepartamento)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_idDepartamento
GO

--Datos adjuntos
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_idAdjunto  FOREIGN KEY(idAdjunto)
REFERENCES  db_soportic.dbo.tbl_datosAdjuntos(idArchivo)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_idAdjunto
GO

--Prioridad
ALTER TABLE db_soportic.dbo.tbl_tickets WITH CHECK ADD CONSTRAINT fk_tickets_idPrioridad  FOREIGN KEY(idPrioridad)
REFERENCES  db_soportic.dbo.tbl_tipoPrioridades(idPrioridad)
GO

ALTER TABLE db_soportic.dbo.tbl_tickets CHECK CONSTRAINT fk_tickets_idPrioridad
GO


------------------TABLA VACACIONES----------------

--Empledo que solicita
ALTER TABLE db_soportic.dbo.tbl_vacaciones WITH CHECK ADD CONSTRAINT fk_vacaciones_idEmpleado  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_vacaciones CHECK CONSTRAINT fk_vacaciones_idEmpleado
GO

--Supervisor que solicita
ALTER TABLE db_soportic.dbo.tbl_vacaciones WITH CHECK ADD CONSTRAINT fk_vacaciones_idSupervisor  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_vacaciones CHECK CONSTRAINT fk_vacaciones_idSupervisor
GO


--------TABLA USUARIOS DE SISTEMA--------------

--idEmpleado
ALTER TABLE db_soportic.dbo.tbl_usuariosSistema WITH CHECK ADD CONSTRAINT fk_usuariosSistema_idEmpleado  FOREIGN KEY(idEmpleado)
REFERENCES  db_soportic.dbo.tbl_empleados(idEmpleado)
GO

ALTER TABLE db_soportic.dbo.tbl_usuariosSistema CHECK CONSTRAINT fk_usuariosSistema_idEmpleado
GO

--idRol
ALTER TABLE db_soportic.dbo.tbl_usuariosSistema WITH CHECK ADD CONSTRAINT fk_usuariosSistema_idRol  FOREIGN KEY(idRol)
REFERENCES  db_soportic.dbo.tbl_descripcionRoles(idRol)
GO

ALTER TABLE db_soportic.dbo.tbl_usuariosSistema CHECK CONSTRAINT fk_usuariosSistema_idRol
GO
