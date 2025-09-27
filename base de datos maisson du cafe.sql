create database maisoon_du_cafe
go
use maisoon_du_cafe
go


create table configuracion_empresa (
idEmpresa int identity(1,1) primary key,
nombreEmpresa varchar(150) not null,
direccion varchar(255),
telefono varchar(15),
email varchar(100),
sitioWeb varchar(100),
logo varbinary(max), -- opcional, para guardar imagen del logo
);
--------------------------------------------definimos roles y sus campos(tiren paroooooooo)------------------------------------
create table roles
(
idRol INT PRIMARY KEY identity(1,1),
nombreRol varchar(100) not null
)
go
create table usuarios
(
idUsuario INT PRIMARY KEY identity(1,1),
nombreUsuario varchar(100) not null,
telefono int,
email varchar(100),
salario decimal(7,2),
contraseña VARBINARY(32),
fechaInicioContrato date,
idRol int,
constraint fkRol foreign key (idRol) references roles(idRol) on delete cascade,
)
go
insert into roles values 
('jefe'),
('empleado'),
('reponedor')

select *from roles
select *from usuarios
delete from usuarios
delete from roles
-------------------------------------el almacen (ayuda me costo mucho)----------------------------------------------------
create table categoria_productos (
idCategoria int identity(1,1) primary key,
nombreCategoria varchar(100) not null,
descripcionCategotria varchar(255)
);

create table productos (
idProducto int identity(1,1) primary key,
nombreProducto varchar(100) not null,
descripcionProducto varchar(255),
idCategoria int,
precioUnitario decimal(10,2),
CostoUnitario decimal(10,2),
constraint fkcategoria FOREIGN KEY (idCategoria) REFERENCES categoria_productos(idCategoria)on delete cascade,
);


create table inventarios (
idInventario int identity(1,1) primary key,
cantidadInventario int not null default 0 check (cantidadInventario >= 0),
estado VARCHAR(20) DEFAULT 'Disponible',
stockMinimo INT DEFAULT 0 CHECK (stockMinimo >= 0),
DescripcionInventario varchar(100),
FechaIngreso date,
idProducto int,
constraint fkProducto foreign key (idProducto) references productos(idProducto) on delete cascade
);

-------------------------ventas------------------------------------------------------------------------
create table ventas
(
idVenta int identity(1,1) primary key,
totalVenta decimal(10,2) check(totalVenta>0),
fechaVenta date not null,
estadoVenta varchar(100),
idUsuario int,
constraint fkUsuarios foreign key (idUsuario) references usuarios(idUsuario) on delete cascade
)

create table detalleVentas
(
idDetalleVenta int identity(1,1) primary key,
productoVenta varchar(100),
cantidadVenta int check (cantidadVenta > 0),
subtotal decimal(10,2),
id_venta int,
idProducto int,
constraint fkProductos foreign key (idProducto) references productos(idProducto) on delete cascade,
constraint fkVenta foreign key (id_venta) references Ventas(idVenta) on delete cascade,
)

select *from detalleVentas
delete from detalleVentas


create view calcularGanancia as
select sum(cantidadInventario * precioUnitario) as total 
from inventarios
inner join
productos on productos.idProducto = inventarios.idProducto