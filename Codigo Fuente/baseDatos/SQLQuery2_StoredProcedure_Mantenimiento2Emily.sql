use soporticDB

go

---------------------------Procedure de almacenamiento para la tabla tipoIdentificaciones-------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertaTipoIdentificacion
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_tipoIdentificaciones(descripcion) values(@descripcion)
end

go

create procedure stp_modificarTipoIdentificacion
(
@id int,
@descripcion varchar(50)
)
as
begin
update  tbl_tipoIdentificaciones
set descripcion = @descripcion
where idTipoIdentificacion = @id
end

go

create procedure stp_traeInfoTipoIdentificacion
(
@id int
)
as
begin
select *from tbl_tipoIdentificaciones where idTipoIdentificacion = @id
end

go


create procedure stp_borrarTipoIdentificacion
(
@id int,
)
as
begin
delete tbl_tipoIdentificaciones  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
where  idTipoIdentificacion = @id
end

go

---------------------------Procedure de almacenamiento para la tabla tipoClientesProveedores-------------
---------------------------------------------------------------------------------------------------------

create procedure stp_insertarTipoClienteProveedor
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_tipoClientesProveedores(descripcion) values(@descripcion)
end

go

create procedure stp_modificarTipoClienteProveedor
(
@id int,
@descripcion varchar(50)
)
as
begin
update tbl_tipoClientesProveedores
set descripcion = @descripcion
where idTipoClienteProveedor = @id
end

go

create procedure stp_traeInfoTipoClienteProveedor
(
@id int
)
as
begin
select *from tbl_tipoClientesProveedores where idTipoClienteProveedor = @id
end
go

create procedure stp_traeTipoClienteProveedor
as
begin
select idTipoClienteProveedor, descripcion from tbl_tipoClientesProveedores
end
go

create procedure stp_traeListaTipoClienteProveedor
as
begin
select idTipoClienteProveedor, descripcion from tbl_tipoClientesProveedores
end
go

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


---------------------------Procedure de almacenamiento para la tabla ticketFacturas-------------------
------------------------------------------------------------------------------------------------------

create procedure stp_insertarTicketFactura
(
@id int,
@idfactura int
)
as
begin
insert into tbl_ticketFacturas(idFactura) values(@idfactura)
end

go

create procedure stp_modificarTicketFactura
(
@id int,
@idfactura int
)
as
begin
update tbl_ticketFacturas
set idFactura = @idfactura
where idTicket = @id
end

go

create procedure stp_traeInfoTicketFactura
(
@id int
)
as
begin
select *from tbl_ticketFacturas where idTicket = @id
end

go

create procedure stp_traeTicketFactura
as
begin
select idTicket, idFactura from tbl_ticketFacturas
end
go

/*ME PREOCUPA ESTA TABLA DE LOS TICKET FACTURA, YA QUE NO SUPE EL CÓMO LLEGARLE PARA HACER LOS PROCEDURE ADECUADAMENTE*/	

---------------------------Procedure de almacenamiento para la tabla descripcionDepartamentos-------------
----------------------------------------------------------------------------------------------------------

create procedure stp_insertarDescripcionDepartamentos
(
@id int,
@descripcion varchar(50)
)
as
begin
insert into tbl_descripcionDepartamentos(descripcion) values(@descripcion)
end

go

create procedure stp_modificarDescripcionDepartamentos
(
@id int,
@descripcion varchar(50)
)
as
begin
update tbl_descripcionDepartamentos
set descripcion = @descripcion
where idTipoDepartamento = @id
end

go

create procedure stp_traeInfoDescripcionDepartamentos
(
@id int
)
as
begin
select *from tbl_descripcionDepartamentos where idTipoDepartamento = @id
end

go

create procedure stp_traeDescripcionDepartamentos
as
begin
select idTipoDepartamento, descripcion from tbl_descripcionDepartamentos
end
go

create procedure stp_borrarDescripcionDepartamentos
(
@id int,
@descripcion varchar(50)
)
as
begin
delete tbl_descripcionDepartamentos  --TENGO PROBLEMAS CON ÉSTA,SI ALGUIEN ME PUEDE ECHAR UNA MANO, CON GUSTO ACEPTO LA AYUDA--
where  idTipoDepartamento = @id
end
go

---------------------------Procedure de almacenamiento para la tabla datosAdjuntos--------------------
------------------------------------------------------------------------------------------------------


create procedure stp_insertarDatosAdjuntos
(
@id int,
@archivo varbinary(max)
)
as
begin
insert into tbl_datosAdjuntos(archivo) values(@archivo)
end

go

create procedure stp_modificarDatosAdjuntos
(
@id int,
@archivo varbinary(max)
)
as
begin
update tbl_datosAdjuntos
set archivo = @archivo
where idArchivo  = @id
end

go

create procedure stp_traeInfoDatosAdjuntos
(
@id int
)
as
begin
select *from tbl_datosAdjuntos where idArchivo  = @id
end

go

create procedure stp_traeDatosAdjuntos
as
begin
select idArchivo, archivo from tbl_datosAdjuntos
end
go

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