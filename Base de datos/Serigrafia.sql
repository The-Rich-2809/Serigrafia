create database Serigrafia
go

 use Serigrafia
 go

 IF OBJECT_ID('Rol') IS NOT NULL
    DROP TABLE Rol;
GO

IF OBJECT_ID('Permiso') IS NOT NULL
    DROP TABLE Permiso;
GO

IF OBJECT_ID('Cliente') IS NOT NULL
    DROP TABLE Cliente;
GO

IF OBJECT_ID('Usuario') IS NOT NULL
    DROP TABLE Usuario;
GO

IF OBJECT_ID('Producto') IS NOT NULL
    DROP TABLE Producto;
GO

IF OBJECT_ID('Catalogo') IS NOT NULL
    DROP TABLE Catalogo;
GO

IF OBJECT_ID('Venta') IS NOT NULL
    DROP TABLE Venta;
GO

IF OBJECT_ID('Detalle_Venta') IS NOT NULL
    DROP TABLE Detalle_Venta;
GO

-- Creaci�n de la tabla Rol para dar roles a los usuarios
CREATE TABLE Rol(
    ID_Rol INT PRIMARY KEY identity,
    Descripcion varchar(50),
	FechaRegistro datetime default getdate() /* se va a generar la fecha actual en el sistema*/
)
go

-- Creaci�n de la tabla Permisos para poder dar una mejor administracion al due�o
CREATE TABLE Permiso (
Id_Permiso int primary key identity,
Id_Rol int references Rol(Id_Rol),
NombreMenu varchar(20),
FechaRegistro datetime default getdate()
);
go

-- Creaci�n de la tabla Cliente
CREATE TABLE Cliente(
Id_Cliente int primary key identity (1,1),
Nombre varchar(50),
Dirrecion varchar(50),
Telefono varchar(10),
);
go

create table Usuario(
Id_Usuario int primary key identity,
Usuario varchar(50),
Nombre varchar (50),
Correo varchar(50),
Contrasena varchar(50),
Id_Rol int references Rol(Id_Rol),
Estado bit,
FechaRegistro datetime default getdate()
);
go

create table Catalogo(
Id_Catalogo int primary key identity,
Descripcion varchar(100),
Estado Bit,
FechaRegistro datetime default getdate()
);
go

create table Producto(
Id_Producto int primary key identity,
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(100),
Id_Catalogo int references Catalogo(Id_Catalogo),
Stock int not null default 0,
Precio_Compra decimal(10,2) default 0,
Precio_Venta decimal(10,2) default 0,
Estado Bit,
FechaRegistro datetime default getdate()
);
go

create table Venta(
Id_Venta int primary key identity,
Id_Usuario int references Usuario(Id_Usuario),/* quien creo la venta */
Tipo_Documento varchar(50),
NombreDocumento varchar (50),
NumeroDocumento varchar (50),
DocumentoCliente varchar (50),
NombreCliente varchar (50),
MontoTotal decimal(10,2),
MontoPago decimal(10,2),
MontoCambio decimal(10,2),
FechaRegistro datetime default getdate()
);
go

create table Detalle_Venta(
Id_DetalleVenta int primary key identity,
Id_Venta int references Venta(Id_Venta),/* quien creo la venta */
Id_Producto int references Producto(Id_Producto),
Precio_Venta decimal(10,2),
Cantidad int,
Subtotal decimal(10,2),
FechaRegistro datetime default getdate()
);
go

-- Cambiar la autorizaci�n de la base de datos
ALTER AUTHORIZATION ON DATABASE::Serigrafia TO SA;
go

INSERT INTO Rol(Descripcion) values
('Administrador'),
('Supervisor'),
('Empleado')
go

INSERT INTO Usuario(Usuario,Nombre,Correo,Contrasena,Id_Rol) VALUES
('evelinakko','Evelyn Sarabi Lopez Montero','evelynsarabi@hotmial.com','capuchino',1),
('aaron','Morales Diaz Santiago Aaron','aaron@gmail.com','1234',2),
('David','Rodriguez Cruz David Emiliano','Davidcruz@hotmail.com','123456',3)
go

INSERT INTO Permiso(Id_Rol,NombreMenu) VALUES
(1,'menuusuarios'),
(1,'menuproductos'),
(1,'menuventas'),
(1,'menuclientes'),
(1,'menureportes'),
(1,'menuacercade')
go

INSERT INTO Permiso(Id_Rol,NombreMenu) VALUES
(2,'menuproductos'),
(2,'menuventas'),
(2,'menuclientes'),
(2,'menureportes'),
(2,'menuacercade')
go

INSERT INTO Permiso(Id_Rol,NombreMenu) VALUES
(3,'menuventas'),
(3,'menuclientes'),
(3,'menureportes'),
(3,'menuacercade')
go

INSERT INTO Cliente(Nombre,Dirrecion,Telefono) VALUES
('Jimena','Jose marya maytorena','5535728451'),
('Rodrigo','Paseo de los caminos','5512913750'),
('Santiago','calle de las luces','5569832802'),
('Marisol','Fuerto de loreto','5592578401'),
('Jose','Miguel de las flores','5612913740'),
('Evelyn','Sendero de la paz','5534728461'),
('David','Balbuena de las torres','5591081035'),
('Emiliano','Ejercito de Oriente','5512913740'),
('Jesus','Guitierres Jimenez','5602734507'),
('Fernando','Jose de los camino','5612488302'),
('Luis','Ratones vaqueros','5801739462'),
('Martha','Squirt de las uvas','5827918304'),
('Miguel','Kingston del mar','5529846203'),
('Eduardo','Rodriguez del muelle','5535728493'),
('Esteban','Praderas del norte ','5509785682');
go

INSERT INTO Catalogo(Descripcion) VALUES
('Gorras'),
('Plumas'),
('Gorras'),
('Tasas');
go

SELECT r.ID_Rol, NombreMenu from Permiso p
INNER JOIN Rol r on r.ID_Rol = p.Id_Rol
inner join Usuario u on u.Id_Rol = r.ID_Rol
where u.Id_Usuario = 1
go