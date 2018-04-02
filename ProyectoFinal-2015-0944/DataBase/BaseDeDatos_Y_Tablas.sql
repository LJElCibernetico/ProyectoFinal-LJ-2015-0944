CREATE DATABASE ProyectoFinalDb;

USE ProyectoFinalDb;

DROP DATABASE master;

DROP DATABASE ProyectoFinalDb;

CREATE TABLE Personas (
  IdPersona int primary key identity(1,1),
  IdTipoPersona int,
  Nombre varchar(max),
  Apellido varchar(max),
  Telefono varchar(max),
  Direccion varchar(max),
  Email varchar(max)
);

DROP TABLE Persona

CREATE TABLE Usuarios (
  IdUsuario int primary key identity(1,1),
  Username varchar(max),
  Password varchar(max),
  Fecha Date,
  Nombre varchar(max),
  Comentario varchar(max)
);

insert into Usuario values('LJ','0515','04-02-2018','Luis Jose','Normal User');
select * from Usuario;

CREATE TABLE Departamentos (
  IdDepartamento int primary key identity(1,1),
  Departamento varchar(max)
);

drop table Departamento;

CREATE TABLE TipoPersona (
  IdTipoPersona int primary key identity(1,1),
  Tipo varchar(max)
);

drop TABLE TiposDePersonas;

CREATE TABLE Compras (
  IdCompra int primary key identity(1,1),
  IdPersona int,
  IdFactura int,
  Monto Money
);

CREATE TABLE FacturaDetalle (
  IdFacturaDetalle int primary key identity(1,1),
  IdFactura int,
  IdProducto int,
  Cantidad int,
  Precio Money
);

CREATE TABLE Facturas (
  IdFactura int primary key identity(1,1),
  IdPersona int,
  Fecha Date,
  Observacion varchar(max),
  Monto Money
);

CREATE TABLE CompraDetalle (
  IdCompraDetalle int primary key identity(1,1),
  IdCompra int,
  IdProducto int,
  Cantidad int,
  Precio Money
);

CREATE TABLE Productos (
  IdProducto int primary key identity(1,1),
  IdDepartamento int,
  Nombre varchar(max),
  Precio Money,
  Existencia int,
  FechaDeVencimiento Date,
  Costo Money
);