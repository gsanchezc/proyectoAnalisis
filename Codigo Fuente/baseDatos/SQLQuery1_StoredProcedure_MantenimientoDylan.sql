
use soporticDB

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

----------------------------------------------------------------------------------------