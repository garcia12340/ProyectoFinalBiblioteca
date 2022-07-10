CREATE DATABASE Biblioteca
GO

USE Biblioteca
GO

--CREACION DE TABLAS
--(1) TABLA MENU
create table MENU(
IdMenu int primary key identity(1,1),
Nombre varchar(60),
Icono varchar(60),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
GO

--(2) TABLA SUBMENU
create table SUBMENU(
IdSubMenu int primary key identity(1,1),
IdMenu int references MENU(IdMenu),
Nombre varchar(60),
NombreFormulario varchar(60),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
GO

--(3) TABLA ROL
create table ROL(
IdRol int primary key identity(1,1),
Descripcion varchar(60),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
GO

--(4) TABLA PERMISOS
create table PERMISOS(
IdPermisos int primary key identity(1,1),
IdRol int references ROL(IdRol),
IdSubMenu int references SUBMENU(IdSubMenu),
Activo bit default 1,
FechaRegistro datetime default getdate()
)
GO

--(5) TABLA USUARIO
Create table USUARIO(
IdUsuario int primary key identity(1,1),
Nombres varchar(100),
Apellidos varchar(100),
IdRol int references ROL(IdRol),
LoginUsuario varchar(50),
LoginClave varchar(50),
--DescripcionReferencia varchar(50),
--IdReferencia int,
Activo bit default 1,
FechaRegistro datetime default getdate()
)
GO

/* CREAMOS LA TABLA LECTOR*/
CREATE TABLE lector(
CodLector int primary key identity,
Nombres varchar(50),
Apellidos varchar(50),
Direccion varchar(100),
Email varchar(60),
Telefono int
)
GO

/* CREAMOS LA TABLA AUTOR*/
CREATE TABLE autor(
CodAutor int primary key identity,
Autor varchar(100)
)
GO

/* CREAMOS LA TABLA GENERO*/
CREATE TABLE genero(
CodGenero int primary key identity,
Genero varchar(100)
)
GO

/* CREAMOS LA TABLA EDITORIAL*/
CREATE TABLE editorial(
CodEditorial int primary key identity,
Editorial varchar(100)
)
GO

/* CREAMOS LA TABLA LIBROS*/
CREATE TABLE libros(
CodLibro int primary key identity,
Titulo varchar(100),
CodAutor int foreign key references autor(CodAutor) on delete cascade on update cascade not null,
CodGenero int foreign key references genero(CodGenero) on delete cascade on update cascade not null,
CodEditorial int foreign key references editorial(Codeditorial) on delete cascade on update cascade not null,
Ubicacion varchar(50),
Cantidad int,
NroEdicion int,--Esperando...
AñoEdicion int
)
GO

/*CREAMOS EL STOCK DE LIBROS */
CREATE TABLE stocklibros(
CodStock int primary key identity,
CodLibro int foreign key references libros(CodLibro) on delete cascade on update cascade not null,
Disponibles int
)
GO

/*CREAMOS LA TABLA PRESTAMO*/
CREATE TABLE prestamo(
CodPrestamo int primary key identity,
CodLector int foreign key references lector(CodLector) on delete cascade on update cascade not null,
CodLibro int foreign key references libros(CodLibro) on delete cascade on update cascade not null,
Fec_Entrega date,
Fec_Devolucion date,
Fec_Retorno date,
Estado varchar(50)
)
GO