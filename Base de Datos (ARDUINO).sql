CREATE DATABASE ARDUINO_BD

GO

USE ARDUINO_BD

GO


create table ROL(
IdRol int primary key identity,
Descripcion varchar(50),
FechaRegistro datetime default getdate()
)
go

create table PERMISO(
IdPermiso int primary key identity,
IdRol int references ROL(IdRol),
NombreMenu varchar(100),
FechaRegistro datetime default getdate()
)
go



create table CLIENTE(
IdCliente int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
go

create table USUARIO(
IdUsuario int primary key identity,
Documento varchar(50),
NombreCompleto varchar(50),
Correo varchar(50),
Clave varchar(50),
IdRol int references ROL(IdRol),
Estado bit,
FechaRegistro datetime default getdate()
)
go



create table CATEGORIA(
IdCategoria int primary key identity,
Descripcion varchar(100),
Estado bit,
FechaRegistro datetime default getdate()
)
go

create table PRODUCTO(
IdProducto int primary key identity,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(50),
IdCategoria int references CATEGORIA(IdCategoria),
Stock int not null default 0,
PrecioCompra decimal(10,2) default 0,
PrecioVenta decimal(10,2) default 0,
Estado bit,
FechaRegistro datetime default getdate()
)
go



create table VENTA(
IdVenta int primary key identity,
IdUsuario int references USUARIO(IdUsuario),
TipoDocumento varchar(50),
NumeroDocumento varchar(50),
DocumentoCliente varchar(50),
NombreCliente varchar(100),
MontoPago decimal(10,2),
MontoPCambio decimal(10,2),
MontoTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
PrecioVenta decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
go


------------------------------- Carga de datos -------------------------------

-- Se inserta los tipos de Roles

insert into rol (Descripcion)
values('ADMINISTRADOR')
go

insert into rol (Descripcion)
values('EMPLEADO')
go

--Consulta la Tabla Rol
 select * from rol


 -- Se inserta los tipos de Permisos para el sistema de Menu

 -- Permisos del tipo "ADMINISTRADOR"
 insert into PERMISO(IdRol,NombreMenu) 
 values
(1,'menuusuarios'),
(1,'menumantenedor'),
(1,'menuventas'),
--(1,'menucompra'),
(1,'menuclientes'),
--(1,'menuproveedores'),
(1,'menureportes'),
(1,'menuacercade')
go

 -- Permisos del tipo "EMPLEADO"
 insert into PERMISO(IdRol,NombreMenu) 
 values
(2,'menuventas'),
--(2,'menucompra'),
(2,'menuclientes'),
--(2,'menuproveedores'),
(2,'menuacercade')
go

--Consulta la Tabla Permiso
 select * from PERMISO
go
---------------- Se generan los metodos para manipular el formulario de USUARIOS ----------------

CREATE PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@IdUsuarioResultado int output,
@Mensaje varchar(500) output
)
as
begin
     set @IdUsuarioResultado = 0
	 set @Mensaje = ''

	 if not exists(select * from USUARIO where Documento = @Documento)
	 begin
	      insert into usuario(Documento,NombreCompleto,Correo,Clave,IdRol,Estado) values
		  (@Documento,@NombreCompleto,@Correo,@Clave,@IdRol,@Estado)

		  set @IdUsuarioResultado = SCOPE_IDENTITY()

     end
	 else
	     set @Mensaje = 'Numero de documento ya existente'

end

go

--Declaracion de Variables para manejo de los metodos
declare @idusuariogenerado int
declare @mensaje varchar(500)
go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_EDITARUSUARIO(
@IdUsuario int, 
@Documento varchar(50),
@NombreCompleto varchar(100),
@Correo varchar(100),
@Clave varchar(100),
@IdRol int,
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''

	 if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	 begin
	      update usuario set 
		  Documento = @Documento,
		  NombreCompleto = @NombreCompleto,
		  Correo = @Correo,
		  Clave = @Clave,
		  IdRol = @IdRol,
		  Estado = @Estado
		  where IdUsuario = @IdUsuario

		  set @Respuesta = 1

     end
	 else
	     set @Mensaje = '!Numero de documento ya existente!'

end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ELIMINARUSUARIO(
@IdUsuario int, 
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''
	 declare @pasoreglas bit = 1

	 if exists (select * from VENTA V
	 inner join usuario u on u.IdUsuario = V.IdUsuario
	 where U.IDUSUARIO = @IdUsuario
	 )
	 begin 
	    set @pasoreglas = 0
        set @Respuesta = 0
	    set @Mensaje = @Mensaje + 'No se puede eliminar por que el usuario se encuentra relacionado a una VENTA\n'
     end

	 if(@pasoreglas = 1)
	 begin
	    delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	 end

end

go
-------------------------------------------------------------------------------------------------------------------


--Se insertan un Usuarios con sus datos correspondientes
insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('1', 'ADMINISTRADOR', '@GMAIL.COM', '1' ,1,1)
go

insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado)
values('2', 'EMPLEADO', '@GMAIL.COM', '2' ,2,1)
go

--Consulta la Tabla Usuario
select * from usuario
