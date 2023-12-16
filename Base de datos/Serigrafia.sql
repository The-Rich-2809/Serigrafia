create database Serigrafia
go

 use Serigrafia
 go

 IF OBJECT_ID('Rol') IS NOT NULL
    DROP TABLE Rol;
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
    ID_Rol INT PRIMARY KEY identity(1,1),
    Descripcion varchar(50),
	FechaRegistro datetime default getdate() /* se va a generar la fecha actual en el sistema*/
)
go

-- Creaci�n de la tabla Cliente
CREATE TABLE Cliente(
Id_Cliente int primary key identity(1,1),
Nombre varchar(50),
Dirrecion varchar(50),
Telefono varchar(10),
);
go

create table Usuario(
Id_Usuario int primary key identity (1,1),
Usuario varchar(50),
Nombre varchar (50),
Correo varchar(50),
Contrasena varchar(50),
Id_Rol int references Rol(Id_Rol),
);
go

create table Catalogo(
Id_Catalogo int primary key identity(1,1),
Descripcion varchar(100),
);
go

create table Producto(
Id_Producto int primary key identity(1,1),
Codigo varchar(50),
Nombre varchar(50),
Descripcion varchar(100),
Id_Catalogo int references Catalogo(Id_Catalogo),
Stock int not null default 0,
Precio_Compra decimal(10,2) default 0,
Precio_Venta decimal(10,2) default 0
);
go

create table Venta(
Id_Venta int primary key identity(1,1),
Id_Usuario int references Usuario(Id_Usuario),/* quien creo la venta */
NombreCliente varchar (50),
MontoTotal decimal(10,2)
);
go

create table Detalle_Venta(
Id_DetalleVenta int primary key identity(1,1),
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
('Empleado')
go

INSERT INTO Usuario(Usuario,Nombre,Correo,Contrasena,Id_Rol) VALUES
('evelinakko','Evelyn Sarabi Lopez Montero','evelynsarabi@hotmial.com','capuchino',1),
('aaron','Morales Diaz Santiago Aaron','aaron@gmail.com','1234',2),
('David','Rodriguez Cruz David Emiliano','Davidcruz@hotmail.com','123456',2)
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

-- Insertar 15 registros en la tabla Producto con Id_Catalogo de 1 a 4
INSERT INTO Producto (Codigo, Nombre, Descripcion, Id_Catalogo, Stock, Precio_Compra, Precio_Venta)
VALUES
  ('COD001', 'Producto 1', 'Descripción del producto 1', 1, 50, 10.99, 19.99),
  ('COD002', 'Producto 2', 'Descripción del producto 2', 2, 30, 8.50, 15.75),
  ('COD003', 'Producto 3', 'Descripción del producto 3', 3, 20, 12.75, 22.50),
  ('COD004', 'Producto 4', 'Descripción del producto 4', 4, 40, 15.25, 28.99),
  ('COD005', 'Producto 5', 'Descripción del producto 5', 1, 60, 9.99, 17.50),
  ('COD006', 'Producto 6', 'Descripción del producto 6', 2, 15, 18.50, 34.75),
  ('COD007', 'Producto 7', 'Descripción del producto 7', 3, 25, 14.99, 25.00),
  ('COD008', 'Producto 8', 'Descripción del producto 8', 4, 10, 21.75, 39.99),
  ('COD009', 'Producto 9', 'Descripción del producto 9', 1, 35, 11.50, 20.25),
  ('COD010', 'Producto 10', 'Descripción del producto 10', 2, 18, 13.25, 24.50),
  ('COD011', 'Producto 11', 'Descripción del producto 11', 3, 22, 16.99, 31.75),
  ('COD012', 'Producto 12', 'Descripción del producto 12', 4, 28, 20.50, 37.25),
  ('COD013', 'Producto 13', 'Descripción del producto 13', 1, 45, 14.75, 26.99),
  ('COD014', 'Producto 14', 'Descripción del producto 14', 2, 12, 22.99, 41.50),
  ('COD015', 'Producto 15', 'Descripción del producto 15', 3, 50, 19.50, 35.99);
Go