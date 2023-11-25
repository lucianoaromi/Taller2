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
Apellido varchar(50),
Nombre varchar(50),
Direccion varchar(100),
Correo varchar(50),
Telefono varchar(50),
Estado bit,
FechaRegistro datetime default getdate()
)
go

create table USUARIO(
IdUsuario int primary key identity,
Documento varchar(50),
Apellido varchar(50),
Nombre varchar(50),
Direccion varchar(100),
Correo varchar(50),
Clave varchar(150),
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
Precio decimal(10,2) default 0,
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
ApellidoCliente varchar(100),
NombreCliente varchar(100),
MontoPago decimal(10,2),
MontoCambio decimal(10,2),
MontoTotal decimal(10,2),
DesMetPago varchar(100),
FechaRegistro datetime default getdate()
)
go

create table DETALLE_VENTA(
IdDetalleVenta int primary key identity,
IdVenta int references VENTA(IdVenta),
IdProducto int references PRODUCTO(IdProducto),
Precio decimal(10,2),
Cantidad int,
SubTotal decimal(10,2),
FechaRegistro datetime default getdate()
)
go

--##########################################################################--
------------------------------- Carga de datos -------------------------------

-- Se inserta los tipos de Roles

insert into rol (Descripcion)
values('EMPLEADO')
go

insert into rol (Descripcion)
values('ADMINISTRADOR')
go

insert into rol (Descripcion)
values('SUPERADMINISTRADOR')
go


--Consulta la Tabla Rol
 select * from rol


 -- Se inserta los tipos de Permisos para el sistema de Menu

 -- Permisos del tipo "EMPLEADO"
 insert into PERMISO(IdRol,NombreMenu) 
 values
(1,'menuventas'),
(1,'menuclientes'),
(1,'menuacercade')
go

 -- Permisos del tipo "ADMINISTRADOR"
 insert into PERMISO(IdRol,NombreMenu) 
 values
(2,'menumantenedor'),
(2,'menuclientes'),
(2,'menudetalleventa'),
(2,'menuestadisticas'),
(2,'menuacercade')
go

 -- Permisos del tipo "SUPERADMINISTRADOR"
 insert into PERMISO(IdRol,NombreMenu) 
 values
(3,'menuusuarios'),
(3,'menubackup'),
(3,'menuacercade')
go

--Consulta la Tabla Permiso
 select * from PERMISO
go


---------------- Se generan los metodos para manipular el formulario de USUARIOS ----------------

--Declaracion de Variables para manejo de los metodos
declare @idusuariogenerado int
declare @mensaje varchar(500)
go


CREATE PROC SP_REGISTRARUSUARIO(
@Documento varchar(50),
@Apellido varchar(100),
@Nombre varchar(100),
@Direccion varchar(100),
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
	      insert into usuario(Documento,Apellido,Nombre,Direccion,Correo,Clave,IdRol,Estado) values
		  (@Documento,@Apellido,@Nombre,@Direccion,@Correo,@Clave,@IdRol,@Estado)

		  set @IdUsuarioResultado = SCOPE_IDENTITY()

     end
	 else
	     set @Mensaje = 'Numero de documento ya existente'

end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_EDITARUSUARIO(
@IdUsuario int, 
@Documento varchar(50),
@Apellido varchar(100),
@Nombre varchar(100),
@Direccion varchar(100),
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
		  Apellido = @Apellido,
		  Nombre = @Nombre,
		  Direccion = @Direccion,
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


---------------- Se generan los metodos para manipular el formulario de CLIENTES ----------------

--Declaracion de Variables para manejo de los metodos
declare @idclientegenerado int
declare @mensaje varchar(500)
go


CREATE PROC SP_REGISTRARCLIENTE(
@Documento varchar(50),
@Apellido varchar(100),
@Nombre varchar(100),
@Direccion varchar(100),
@Correo varchar(100),
@Telefono varchar(100),
@Estado bit,
@IdClienteResultado int output,
@Mensaje varchar(500) output
)
as
begin
     set @IdClienteResultado = 0
	 set @Mensaje = ''

	 if not exists(select * from CLIENTE where Documento = @Documento)
	 begin
	      insert into cliente(Documento,Apellido,Nombre,Direccion,Correo,Telefono,Estado) values
		  (@Documento,@Apellido,@Nombre,@Direccion,@Correo,@Telefono,@Estado)

		  set @IdClienteResultado = SCOPE_IDENTITY()

     end
	 else
	     set @Mensaje = 'Numero de documento ya existente'

end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_EDITARCLIENTE(
@IdCliente int, 
@Documento varchar(50),
@Apellido varchar(100),
@Nombre varchar(100),
@Direccion varchar(100),
@Correo varchar(100),
@Telefono varchar(100),
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''

	 if not exists(select * from CLIENTE where Documento = @Documento and IdCliente != @IdCliente)
	 begin
	      update cliente set 
		  Documento = @Documento,
		  Apellido = @Apellido,
		  Nombre = @Nombre,
		  Direccion = @Direccion,
		  Correo = @Correo,
		  Telefono = @Telefono,
		  Estado = @Estado
		  where IdCliente = @IdCliente

		  set @Respuesta = 1

     end
	 else
	     set @Mensaje = '!Numero de documento ya existente!'

end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ELIMINARCLIENTE(
@IdCliente int, 
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''



	    delete from CLIENTE where IdCliente = @IdCliente
		set @Respuesta = 1


end

go

---------------- Se generan los metodos para manipular el formulario de CATEGORIA ----------------

--Declaracion de Variables para manejo de los metodos
declare @idcategoriagenerado int
declare @mensaje varchar(500)
go


CREATE PROCEDURE SP_REGISTRARCATEGORIA(
    @Descripcion VARCHAR(50),
    @Estado BIT,
    @IdCategoriaResultado INT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    SET @IdCategoriaResultado = 0
    SET @Mensaje = ''

    IF NOT EXISTS (SELECT * FROM CATEGORIA WHERE Descripcion = @Descripcion)
    BEGIN
        INSERT INTO categoria (Descripcion, Estado) VALUES
        (@Descripcion, @Estado)

        SET @IdCategoriaResultado = SCOPE_IDENTITY()
    END
    ELSE
    BEGIN
        SET @Mensaje = 'La categor�a con la misma descripci�n ya existe'
    END
END
GO


-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_EDITARCATEGORIA(
@IdCategoria int, 
@Descripcion varchar(50),
@Estado bit,
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''

	 if not exists(select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
	 begin
	      update categoria set 
		  Descripcion = @Descripcion,
		  Estado = @Estado
		  where IdCategoria = @IdCategoria

		  set @Respuesta = 1

     end
	 else
	     set @Mensaje = '!La Categoria ya existente!'

end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ELIMINARCATEGORIA(
@IdCategoria int, 
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''



	    delete from CATEGORIA where IdCategoria = @IdCategoria
		set @Respuesta = 1


end

go


---------------- Se generan los metodos para manipular el formulario de PRODUCTOS ----------------

--Declaracion de Variables para manejo de los metodos
declare @idproductogenerado int
declare @mensaje varchar(500)
go

-- Definir el procedimiento almacenado
CREATE PROC SP_REGISTRARPRODUCTO(
    @Codigo varchar(50),
    @Nombre varchar(100),
    @Descripcion varchar(100),
    @IdCategoria int,
	@Stock int,
	@Precio decimal,
    @Estado bit,
    @Resultado int output,
    @Mensaje varchar(500) output
)
as
begin
    set @Resultado = 0
    set @Mensaje = ''

    -- Verificar si el producto ya existe por su C�digo
    if not exists(select * from PRODUCTO where Codigo = @Codigo)
    begin
        -- Insertar el nuevo producto
        insert into PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria,Stock,Precio,Estado) 
        values (@Codigo, @Nombre, @Descripcion, @IdCategoria,@Stock,@Precio,@Estado)

        -- Obtener el ID del producto reci�n insertado
        set @Resultado = SCOPE_IDENTITY()
    end
    else
        set @Mensaje = 'C�digo ya existente'

end


go

-------------------------------------------------------------------------------------------------------------------

-- Definir el procedimiento almacenado
CREATE PROC SP_EDITARPRODUCTO (
    @IdProducto int,
    @Codigo varchar(50),
    @Nombre varchar(100),
    @Descripcion varchar(100),
    @IdCategoria int,
	@Stock int,
	@Precio decimal,
    @Estado bit,
    @Resultado bit output,
    @Mensaje varchar(500) output
)
as
begin
    set @Resultado = 1

    -- Verificar si otro producto ya tiene el mismo C�digo
    if not exists(select * from PRODUCTO where codigo = @Codigo and IdProducto != @IdProducto)

        -- Actualizar el producto existente con los nuevos valores
        update PRODUCTO set 
            codigo = @Codigo,
            Nombre = @Nombre,
            Descripcion = @Descripcion,
            IdCategoria = @IdCategoria,
			Stock = @Stock,
			Precio = @Precio,
            Estado = @Estado
            where IdProducto = @IdProducto
     else
	 begin
        -- Establecer la respuesta como 1 para indicar �xito
        set @Resultado = 0
		set @Mensaje = '�C�digo de producto ya existente!'
    end
end

go

-------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_ELIMINARPRODUCTO(
@IdProducto int, 
@Respuesta bit output,
@Mensaje varchar(500) output
)
as
begin
     set @Respuesta = 0
	 set @Mensaje = ''
	 declare @pasoreglas bit = 1

	 if exists (select * from DETALLE_VENTA dv
	 inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	 where dv.IdProducto = @IdProducto
	 )
	 begin 
	    set @pasoreglas = 0
        set @Respuesta = 0
	    set @Mensaje = @Mensaje + 'No se puede eliminar el producto por que se encuentra relacionado a una VENTA'
     end

	 if(@pasoreglas = 1)
	 begin
	    delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	 end

end

go

-------------------------------------------------------------------------------------------------------------------

--Se insertan un Usuarios con sus datos correspondientes
-- LAS CLAVES AL HABER SIDO ENCRIPTADAS SERAN REGISTRADAS DE TAL MODO, EL VALOR DE TODAS ES LA MISMA (123)

insert into USUARIO(Documento, Apellido, Nombre,Direccion, Correo, Clave, IdRol, Estado)
values
('11111111', 'ApeUsuario1','NomUsuario1','Casita 1', '@GMAIL.COM', '$2a$11$11YH.2nEoLsOjMogIXeY9eSeQ1n3FwGgc2/K0cJejVIHGc0k3ld2G' ,1,1),
('22222222', 'ApeUsuario2','NomUsuario2','Casita 2', '@GMAIL.COM', '$2a$11$vfJOhNuMlA0wV6iCbWOmHO8FsYhYtpkmZyyWaIdP.3T77GHdCGB9W' ,1,1),
('33333333', 'ApeUsuario3','NomUsuario3','Casita 3', '@GMAIL.COM', '$2a$11$kcGAIS1MGXAcK2ZUOltByem6TRVBaZsJjGEPtSqjscM3CFI4QLDrC' ,2,1),
('44444444', 'ApeUsuario4','NomUsuario4','Casita 4', '@GMAIL.COM', '$2a$11$QktLppcleoNEj9yAjwDibubUlGmIx9uIpxNhfvpUgsK.MHshqe2C2' ,3,1);
go


--Consulta la Tabla Usuario
select * from usuario


-------------------------------------------------------------------------------------------------------------------

-- Generar 10 registros en la tabla CLIENTE con n�meros de documento de Argentina (DNI)
INSERT INTO CLIENTE (Documento, Apellido, Nombre, Direccion, Correo, Telefono, Estado)
VALUES
('12345678', 'G�mez', 'Ana', 'Calle 123', 'ana@gmail.com', '123456789', 1),
('87654321', 'L�pez', 'Juan', 'Avenida 456', 'juan@gmail.com', '987654321', 1),
('11223344', 'Rodr�guez', 'Luc�a', 'Calle Principal', 'lucia@gmail.com', '555555555', 1),
('55443322', 'Mart�nez', 'Carlos', 'Boulevard 789', 'carlos@gmail.com', '777777777', 1),
('48765432', 'Fern�ndez', 'Sof�a', 'Calle Secundaria', 'sofia@gmail.com', '999999999', 1),
('31223344', 'P�rez', 'Luis', 'Calle de la Plaza', 'luis@gmail.com', '111111111', 1),
('35443322', 'Garc�a', 'Mar�a', 'Avenida Central', 'maria@gmail.com', '222222222', 1),
('98765432', 'D�az', 'Pedro', 'Calle 456', 'pedro@gmail.com', '333333333', 1),
('37654321', 'Vargas', 'Elena', 'Calle 789', 'elena@gmail.com', '444444444', 1),
('32345678', 'S�nchez', 'Jorge', 'Avenida 123', 'jorge@gmail.com', '666666666', 1);


select * from cliente

-------------------------------------------------------------------------------------------------------------------

--Se insertan una Categoria con sus datos correspondientes

insert into	CATEGORIA(Descripcion,Estado)
values
('Placa',1),
('Modulo',1),
('Sensor',1);
go

select * from CATEGORIA
go

-------------------------------------------------------------------------------------------------------------------

select * from PRODUCTO

--Pone por defecto el Estado en activo del Producto
update PRODUCTO set	Estado = 1

-- Insertar registros en la tabla PRODUCTO
INSERT INTO PRODUCTO (Codigo, Nombre, Descripcion, IdCategoria, Stock, Precio, Estado)
VALUES
('ARD001', 'Arduino Uno', 'Placa de desarrollo basada en ATmega328P', 1, 50, 10900.00, 1),
('ARD002', 'Arduino Nano', 'Versi�n compacta de la placa Arduino', 2, 30, 8500.00, 1),
('ARD003', 'Sensor de Temperatura', 'Sensor de temperatura para proyectos Arduino', 1, 40, 5500.00, 1),
('ARD004', 'M�dulo Bluetooth HC-05', 'M�dulo Bluetooth para comunicaci�n inal�mbrica', 3, 20, 6300.00, 1),
('ARD005', 'Servomotor SG90', 'Servomotor peque�o para proyectos de rob�tica', 2, 60, 3300.00, 1),
('ARD006', 'Pantalla LCD 16x2', 'Pantalla alfanum�rica para mostrar informaci�n', 1, 10, 7200.00, 1),
('ARD007', 'Kit de Inicio Arduino', 'Kit completo para principiantes en Arduino', 2, 45, 22000.00, 1),
('ARD008', 'M�dulo WiFi ESP8266', 'M�dulo WiFi para conectar proyectos a la red', 3, 55, 5000.00, 1),
('ARD009', 'Sensor de Movimiento PIR', 'Sensor de movimiento para detecci�n', 1, 25, 3900.00, 1),
('ARD010', 'Motor Paso a Paso', 'Motor para control preciso de movimiento', 2, 15, 5800.00, 1),
('ARD011', 'Shield Ethernet W5100', 'Shield para conectar Arduino a la red Ethernet', 1, 48, 11900.00, 1),
('ARD012', 'M�dulo GPS NEO-6M', 'M�dulo GPS para proyectos de localizaci�n', 3, 32, 14900.00, 1),
('ARD013', 'Sensor de Luz LDR', 'Sensor de luz para medir niveles de iluminaci�n', 2, 37, 2800.00, 1),
('ARD014', 'M�dulo Rel�', 'M�dulo para controlar dispositivos externos', 1, 22, 6600.00, 1),
('ARD015', 'M�dulo RFID RC522', 'M�dulo para lectura de tarjetas RFID', 3, 18, 9400.00, 1),
('ARD016', 'Joystick Arduino', 'Joystick para control manual en proyectos', 2, 28, 8300.99, 1),
('ARD017', 'Sensor Ultras�nico HC-SR04', 'Sensor de distancia para mediciones precisas', 1, 42, 3500.00, 1),
('ARD018', 'M�dulo RTC DS3231', 'M�dulo de tiempo real para llevar el tiempo', 3, 13, 6000.00, 1),
('ARD019', 'Kit de Sensores Arduino', 'Kit variado con sensores para proyectos', 2, 19, 16500.00, 1),
('ARD020', 'Display 7 Segmentos', 'Display para mostrar n�meros en proyectos', 1, 33, 3300.00, 1);


---------------- Se generan los metodos para manipular el formulario de Ventas ----------------
CREATE TYPE dbo.EDetalle_Venta AS TABLE
(
    IdProducto INT,
    Precio DECIMAL(18, 2),
    Cantidad INT,
    SubTotal DECIMAL(18, 2)
);
GO


CREATE PROCEDURE usp_RegistrarVenta
(
    @IdUsuario INT,
    @TipoDocumento VARCHAR(500),
    @NumeroDocumento VARCHAR(500),
    @DocumentoCliente VARCHAR(500),
    @ApellidoCliente VARCHAR(100),
    @NombreCliente VARCHAR(100),
    @MontoPago DECIMAL(18, 2),
    @MontoCambio DECIMAL(18, 2),
    @MontoTotal DECIMAL(18, 2),
    @DesMetPago VARCHAR(100),
    @DetalleVenta EDetalle_Venta READONLY,
    @Resultado BIT OUTPUT,
    @Mensaje VARCHAR(500) OUTPUT
)
AS
BEGIN
    BEGIN TRY
        DECLARE @IdVenta INT = 0;
        SET @Resultado = 1;
        SET @Mensaje = '';

        BEGIN TRANSACTION Registro;

        INSERT INTO VENTA(IdUsuario, TipoDocumento, NumeroDocumento, DocumentoCliente, ApellidoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal, DesMetPago)
        VALUES (@IdUsuario, @TipoDocumento, @NumeroDocumento, @DocumentoCliente, @ApellidoCliente, @NombreCliente, @MontoPago, @MontoCambio, @MontoTotal, @DesMetPago);

        SET @IdVenta = SCOPE_IDENTITY();

        INSERT INTO DETALLE_VENTA(IdVenta, IdProducto, Precio, Cantidad, SubTotal)
        SELECT @IdVenta, IdProducto, Precio, Cantidad, SubTotal FROM @DetalleVenta;

        COMMIT TRANSACTION Registro;
    END TRY
    BEGIN CATCH
        SET @Resultado = 0;
        SET @Mensaje = ERROR_MESSAGE();
        ROLLBACK TRANSACTION Registro;
    END CATCH;
END;
GO

-------------------------------------- Consalta de Detalle de Venta ------------------------------------------

select v.IdVenta,u.Apellido,u.Nombre,
v.DocumentoCliente, v.ApellidoCliente,v.NombreCliente,
v.TipoDocumento,v.NumeroDocumento,
v.MontoPago,v.MontoCambio,v.MontoTotal,v.DesMetPago,
convert (char(10),v.FechaRegistro,103)[FechaRegistro]
from VENTA v
inner join USUARIO u on u.IdUsuario = v.IdUsuario
where v.NumeroDocumento = '00001'
go

select 
p.Nombre,dv.Precio,dv.Cantidad,dv.SubTotal
from DETALLE_VENTA dv
inner join PRODUCTO p on p.IdProducto = dv.IdProducto
where dv.IdVenta = 1
go



------------------------------------- Procedimiento Almacenado Reporte de Ventas -------------------------------------

CREATE PROC sp_ReporteVentas111(
    @fechainicio VARCHAR(10),
    @fechafin VARCHAR(10),
    @idusuario INT
)
AS
BEGIN
    SET DATEFORMAT dmy;

    SELECT 
        CONVERT(char(10), v.FechaRegistro, 103) AS [FechaRegistro],
        v.TipoDocumento,
        v.NumeroDocumento,
        v.MontoTotal,
        u.Apellido AS [UsuarioRegistro],
        v.DocumentoCliente,
        v.ApellidoCliente,
        p.Codigo AS [CodigoProducto],
        p.Nombre AS [NombreProducto],
        ca.Descripcion AS [Categoria],
        dv.Precio,
        dv.Cantidad,
        dv.SubTotal,
		v.DesMetPago
    FROM 
        Venta v
        LEFT JOIN USUARIO u ON u.IdUsuario = v.IdUsuario
        LEFT JOIN DETALLE_VENTA dv ON dv.IdVenta = v.IdVenta
        LEFT JOIN PRODUCTO p ON p.IdProducto = dv.IdProducto
        LEFT JOIN CATEGORIA ca ON ca.IdCategoria = p.IdCategoria
    WHERE 
        CONVERT(DATE, v.FechaRegistro) BETWEEN @fechainicio AND @fechafin
        AND (
            u.IdUsuario = @idusuario 
            OR NOT EXISTS (SELECT 1 FROM Venta v2 WHERE v2.IdUsuario = @idusuario)
        );
END
GO


------------------------------------- Prueba de Procedimiento Almacenado -------------------------------------

exec sp_ReporteVentas111 '01/11/2023','11/11/2023',6
go

--------------------------------------------------------------------------------------------------------------

create table METODO_PAGO(
IdMetodoPago int primary key identity,
DesMetPago varchar(100),
CodMetodoPago varchar(50),
FechaRegistro datetime default getdate()
)
go


insert into METODO_PAGO(DesMetPago,CodMetodoPago) 
 values
('Tarj. Credito',1),
('Tarj. Debito',2),
('Efectivo',3),
('Transferencia',4),
('QR',5)
go

select * from METODO_PAGO
go

drop table METODO_PAGO


----------------------------------------------------------------------------------------------------------------------------------------

DECLARE @DetalleVenta EDetalle_Venta;

INSERT INTO @DetalleVenta (IdProducto, Precio, Cantidad, SubTotal)
VALUES
(1, 50.00, 2, 100.00),
(2, 30.00, 3, 90.00),
(3, 25.00, 1, 25.00);

DECLARE @Resultado BIT;
DECLARE @Mensaje VARCHAR(500);

-- Otros par�metros
DECLARE @IdUsuario INT = 1;  -- Proporciona el valor correcto para @IdUsuario
DECLARE @TipoDocumento VARCHAR(500) = 'Factura';  -- Proporciona el valor correcto para @TipoDocumento
DECLARE @NumeroDocumento VARCHAR(500) = '00009';  -- Proporciona el valor correcto para @NumeroDocumento
DECLARE @DocumentoCliente VARCHAR(500) = '123456';  -- Proporciona el valor correcto para @DocumentoCliente
DECLARE @ApellidoCliente VARCHAR(100) = 'P�rez';  -- Proporciona el valor correcto para @ApellidoCliente
DECLARE @NombreCliente VARCHAR(100) = 'Juan';  -- Proporciona el valor correcto para @NombreCliente
DECLARE @MontoPago DECIMAL(18, 2) = 300.00;  -- Proporciona el valor correcto para @MontoPago
DECLARE @MontoCambio DECIMAL(18, 2) = 50.00;  -- Proporciona el valor correcto para @MontoCambio
DECLARE @MontoTotal DECIMAL(18, 2) = 350.00;  -- Proporciona el valor correcto para @MontoTotal
DECLARE @DesMetPago VARCHAR(100) = 'Efectivo';  -- Proporciona el valor correcto para @DesMetPago

-- Llamada al procedimiento almacenado
EXEC usp_RegistrarVenta
    @IdUsuario = @IdUsuario,
    @TipoDocumento = @TipoDocumento,
    @NumeroDocumento = @NumeroDocumento,
    @DocumentoCliente = @DocumentoCliente,
    @ApellidoCliente = @ApellidoCliente,
    @NombreCliente = @NombreCliente,
    @MontoPago = @MontoPago,
    @MontoCambio = @MontoCambio,
    @MontoTotal = @MontoTotal,
    @DesMetPago = @DesMetPago,
    @DetalleVenta = @DetalleVenta,  -- Pasa la tabla tipo como par�metro directamente
    @Resultado = @Resultado OUTPUT,  -- Agrega los par�metros de salida
    @Mensaje = @Mensaje OUTPUT;

IF @Resultado = 1
    PRINT 'Venta registrada con �xito';
ELSE
    PRINT 'Error al registrar la venta. Mensaje: ' + @Mensaje;




