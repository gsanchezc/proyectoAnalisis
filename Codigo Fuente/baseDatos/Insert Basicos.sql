use db_soportic
go

insert into [db_soportic].[dbo].[tbl_Departamentos]
values (N'SOFTWARE', 0),
		(N'HARDWARE', 0),
		(N'WEB', 0),
		(N'ACCESOS', 0)
go

insert into [db_soportic].[dbo].[tbl_descripcionRoles]
values (N'Administrador', 0),
		(N'Supervisor', 0),
		(N'Tecnico', 0),
		(N'RRHH', 0),
		(N'Contabilidad', 0),
		(N'Cliente', 0)
go

insert into [db_soportic].[dbo].[tbl_estatusAlertas]
values (N'Alerta Activa', 0),
		(N'Alerta Finalizada', 0)
go

insert into [db_soportic].[dbo].[tbl_estatusTickets]
values (N'Pendiente de Asignacion', 0, N'Supervisor'),
		(N'Asignado a Tecnico', 0, N'Tecnico'),
		(N'Pendiente de Aprobacion', 0, N'Supervisor'),
		(N'Rechazado', 0, N'Tecnico'),
		(N'Aprobado', 0, N'Supervisor')
go

insert into [db_soportic].[dbo].[tbl_salarios]
values (CAST(350000.00 AS Decimal(18, 2)), 0),
		(CAST(450000.00 AS Decimal(18, 2)), 0),
		(CAST(600000.00 AS Decimal(18, 2)), 0),
		(CAST(800000.00 AS Decimal(18, 2)), 0),
		(CAST(1000000.00 AS Decimal(18, 2)), 0)
go

insert into [db_soportic].[dbo].[tbl_TipoAlertas]
values (N'Cedula Residencia', 0),
		(N'RRHH', 0),
		(N'Comunicados', 0)
go

insert into [db_soportic].[dbo].[tbl_tipoIdentificaciones]
values (N'Cedula Nacional', 0),
		(N'Cedula Juridica', 0),
		(N'Pasaporte', 0),
		(N'Cedula Residencia', 0)
go

insert into [db_soportic].[dbo].[tbl_tipoPrioridades]
values (N'No definida', 0),
		(N'Baja', 0),
		(N'Media', 0),
		(N'Alta', 0),
		(N'Urgente', 0),
		(N'Critico', 0)
go

insert into [db_soportic].[dbo].[tbl_tipoPuestos]
values  (N'Administrador', 0),
		(N'Supervisor', 0),
		(N'Tecnico', 0),
		(N'RRHH', 0),
		(N'Contabilidad', 0)
go

insert into [db_soportic].[dbo].[tbl_tipoServicio]
values (N'Solicitud', 0),
		(N'Incidente', 0),
		(N'Queja', 0)
go

insert into [db_soportic].[dbo].[tbl_empresasClientes]
values (N'Credomapic S.A', 3, N'3101123456', N'88888888', 0, N'San Jose, Costa Rica, Edificio El Roble Escazu'),
		(N'Banco BCCR S.A', 3, N'3102204060', N'44444444', 0, N'San Jose, Costa Rica Edificio Negro en San Jose Centro'),
		(N'ICEL S.A', 3, N'3110809078', N'55555555', 0, N'San Jose, San Pedro, frente al Mall'),
		(N'AYAY S.A', 3, N'3101906735', N'66666666', 0, N'Frente a paseo de los estudiantes'),
		(N'CCSD S.A', 3, N'3102467890', N'88888888', 0, N'Frente al teatro nacional')
go

insert into [db_soportic].[dbo].[tbl_clientesProveedores]
values (3, N'3101101010', N'ChorimoS.A', N'San Jose', N'22807090', 0),
		(3, N'3101151520', N'Aegis Communications', N'Alajuela', N'22806800', 0),
		(3, N'3102205080', N'Client Services', N'Heredia', N'22605050', 0),
		(3, N'3101505780', N'HP', N'Cartago', N'25604890', 0),
		(3, N'3101457800', N'Electronica 2000', N'Guanacaste', N'50703090', 0),
		(3, N'3101789056', N'Motos UM', N'La Uruca de Abonos Agro 100 Sur', N'22680090', 0)
go

insert into [db_soportic].[dbo].[tbl_clientesUsuarioFinal]
values (null, N'Meyling', N'Sanchez', 4, N'155890345124', N'22807000',1, 0),
		(null, N'Ignasio', N'Fallas', 1, N'110890760', N'22348000',2,0),
		(null, N'Emily', N'Corella', 1,  N'110680345', N'22253538',3,0)
go

insert into [db_soportic].[dbo].[tbl_empleados]
values (null, N'Rafael', N'Sequeira', 1, N'110680674', CAST(0x0000722300000000 AS DateTime), N'rsequeirav@gmail.com', N'San Jose', 1, 2, N'22253539', N'86431593', CAST(0x00008EAC00000000 AS DateTime), 20, 1, 0),
       (null, N'Diego', N'Venegas', 1, N'207800567', CAST(0x00007A9F00000000 AS DateTime), N'dvenegas@hotmail.com', N'Heredia', 2, 3, N'22406080', N'83467800', CAST(0x0000A13900000000 AS DateTime), 5, 2, 0),
       (null, N'Gustavo', N'Sanchez', 1, N'303900789', CAST(0x00006CF000000000 AS DateTime), N'gsanchez@gmail.com', N'Alajueala', 1, 1, N'29000000', N'89005050', CAST(0x0000A15900000000 AS DateTime), 6, 3, 0),
		(null, N'Cesar', N'Urena', 1, N'408000900', CAST(0x00007A0100000000 AS DateTime), N'curena@yahoo.com', N'Cartago', 3, 3, N'28009040', N'86754567', CAST(0x0000A27C00000000 AS DateTime), 1, 1, 0),
       (null, N'Andres', N'Ramirez', 1, N'108970456', CAST(0x000080B900000000 AS DateTime), N'aramirez', N'Cartago', 1, 5, N'23907643', N'87463000', CAST(0x0000A28100000000 AS DateTime), 5, 3, 0)
go

insert into [db_soportic].[dbo].[tbl_usuariosSistema]
values (N'rsequeirav', N'6ee8335411a31bee442cc4ee08a4c266', 2, 0, 0),
		(N'msanchez', N'3336c54e4c31ac082274a0dd13ba69b0', 6, 0, 0),
		(N'ifallas1', N'd785fe345f74350518bfa2e31c768f56', 6, 0, 0),
		(N'ecorella', N'6ee8335411a31bee442cc4ee08a4c266', 6, 0, 0),
		(N'dvenegas', N'c81b5cd5b382dfdcfbfff1ed9a164b10', 3, 0, 0),
		(N'gsanchez', N'a797683bca2af94d35eeebc4637072a5', 1, 0, 0),
		(N'curena', N'ee97d8349c75ccf8da5d6df6223b1db1', 3, 0, 0),
		(N'aramirez', N'5ac5a268f12949edfdce3c61595e9971', 5, 0, 0)
go

update dbo.tbl_clientesUsuarioFinal
set idUsuarioSistema = 2
where idClienteUsuarioFinal = 1000000
go

update dbo.tbl_clientesUsuarioFinal
set idUsuarioSistema = 3
where idClienteUsuarioFinal = 1000001
go

update dbo.tbl_clientesUsuarioFinal
set idUsuarioSistema = 4
where idClienteUsuarioFinal = 1000002
go

update dbo.tbl_empleados
set idUsuarioSistema = 1
where idEmpleado = 1
go

update dbo.tbl_empleados
set idUsuarioSistema = 5
where idEmpleado = 2
go

update dbo.tbl_empleados
set idUsuarioSistema = 6
where idEmpleado = 3
go

update dbo.tbl_empleados
set idUsuarioSistema = 7
where idEmpleado = 4
go

update dbo.tbl_empleados
set idUsuarioSistema = 8
where idEmpleado = 5
go