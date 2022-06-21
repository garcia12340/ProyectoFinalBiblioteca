USE Biblioteca
GO

INSERT INTO ROL(Descripcion) VALUES
('ADMINISTRADOR'),
('BIBLIOTECARIO')
GO

USE MASTER

--INSERTAR MENU

INSERT INTO MENU(Nombre,Icono) VALUES 
 ('Usuario','\Iconos\Usuarios.png'),
 ('Bibliotecario','\Iconos\biblio.png'),
 ('Transacciones','\Iconos\transaccion.png'),
 ('Reportes','\Iconos\Reportes.png'),
 ('Libros','\Iconos\libros.png'),
 ('Lector','\Iconos\lector.png')
 GO
 SELECT * FROM MENU

 --DROP TABLE MENU

 --MENU USUARIOS
 INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Usuarios'),'Crear Usuario','CrearUsuario'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Usuarios'),'Crear Rol','CrearRol'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Usuarios'),'Asignar Rol Permisos','RolPermiso')
 GO

  --MENU Bibliotecario
 INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Bibliotecario'),'Mostrar Bibliotecario','Bibliotecario'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Bibliotecario'),'Nuevo Bibliotecario','NuevoBibliotecario'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Bibliotecario'),'Modificar Bibliotecario','ModificarBibliotecario')
 GO

  --MENU TRANSACCIONES
 INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Regristro Prestamo','NuevoPrestamo'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Libros Prestados','LibrosPrestados'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Libros Devueltos','LibrosDevueltos')
GO

--MENU REPORTES
INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Reportes'),'Reportes Libros','ReportesLibros'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Reportes'),'Reportes Prestamo','ReportesPrestamo')
GO

--MENU LIBROS
INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Mostrar Libros','Libros'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Nuevo Libros','Nuevo Libro'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Modificar Libros','ModificarLibro'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Opciones Autor','Autor'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Opciones Genero','Genero'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Opciones Editorial','Editorial')
GO

--MENU LECTOR
INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Lector'),'Mostrar Lector','Lector'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Bibliotecario'),'Nuevo Lector','NuevoLector'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Bibliotecario'),'Modificar Lector','ModificarLector')
 GO
  SELECT * FROM SUBMENU

--INSERTAR USUARIO
INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave,DescripcionReferencia,IdReferencia)
VALUES('Ricardo','Garcia',(SELECT TOP 1 IdRol FROM ROL WHERE Descripcion = 'ADMINISTRADOR'),'garcia2020','Managua2022','NINGUNA',0)
GO

INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave,DescripcionReferencia,IdReferencia)
VALUES('Eduardo','Obando',(SELECT TOP 1 IdRol FROM ROL WHERE Descripcion = 'BIBLIOTECARIO'),'eduardo2020','Sistemas123','NINGUNA',0)
GO

INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave,DescripcionReferencia,IdReferencia)
VALUES('Elvis','Gomez',(SELECT TOP 1 IdRol FROM ROL WHERE Descripcion = 'ADMINISTRADOR'),'elvis2020','Nicaragua2022','NINGUNA',0)
GO

SELECT * FROM USUARIO

--INSERTAR PERMISOS
INSERT INTO PERMISOS(IdRol,IdSubMenu)
SELECT (select TOP 1 IdRol from ROL where Descripcion = 'ADMINISTRADOR'), IdSubMenu FROM SUBMENU
GO

INSERT INTO PERMISOS(IdRol,IdSubMenu,Activo)
SELECT (select TOP 1 IdRol from ROL where Descripcion = 'BIBLIOTECARIO'),IdSubMenu,0 FROM SUBMENU
GO

SELECT * FROM PERMISOS

--update p set p.Activo = 1 from PERMISOS p
--inner join SUBMENU sm on sm.IdSubMenu = p.IdSubMenu
--where sm.NombreFormulario in ('frmNuevoPrestamo','frmLibrosDevueltos') and p.IdRol = (select TOP 1 IdRol from ROL where Descripcion = 'DOCENTE')
--GO

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

INSERT INTO editorial VALUES('Navarrete')
INSERT INTO editorial VALUES('Sierra')
INSERT INTO editorial VALUES('Random House')
INSERT INTO editorial VALUES('Alfaguara')
INSERT INTO editorial VALUES('Letras Hispanicas')
INSERT INTO editorial VALUES('Fondo de Cultura Económica')
INSERT INTO editorial VALUES('Debolsillo')
INSERT INTO editorial VALUES('Talleres de la penitencia de lima')
GO
SELECT * FROM editorial

INSERT INTO autor VALUES('Cesar Vallejo')
INSERT INTO autor VALUES('CIRE')
INSERT INTO autor VALUES('Gabriel García Márquez')
INSERT INTO autor VALUES('Mario Vargas LLosa')
INSERT INTO autor VALUES('Augusto Roa Bastos')
INSERT INTO autor VALUES('Carlos Fuentes')
INSERT INTO autor VALUES('Laura Esquivel')
GO
SELECT * FROM autor

INSERT INTO genero VALUES('Magical Realism, Novela')
INSERT INTO genero VALUES('Poema')
INSERT INTO genero VALUES('Ficción Histórica')
INSERT INTO genero VALUES('Ficción')
INSERT INTO genero VALUES('Tragedia')
INSERT INTO genero VALUES('Lírico')
GO
SELECT * FROM genero

INSERT INTO libros VALUES ('Los perros y la ciudad',4,1,1,'Seccion L',100)
INSERT INTO libros VALUES ('Cien Años de Soledad',4,1,4,'Seccion C',80)
INSERT INTO libros VALUES ('La Fiesta del Chivo',4,4,5,'Seccion L',90)
INSERT INTO libros VALUES ('Yo el Sumpremo',6,4,6,'Seccion Y',95)
INSERT INTO libros VALUES ('La Guerra del Fin del Mundo',5,5,5,'Seccion L',75)
INSERT INTO libros VALUES ('La Muerte de Artemio Cruz',6,1,7,'Seccion L',96)
INSERT INTO libros VALUES ('Como Agua para Chocolate',7,6,7,'Seccion C',84)
INSERT INTO libros VALUES ('Los Heraldos Negros',1,6,8,'Seccion L',56)
GO
SELECT * FROM libros

INSERT INTO lector VALUES ('Yamile','Pinto','Av. Locura','yamile@hotmail.com',963852741)
INSERT INTO lector VALUES ('Fiorela','Escovar','Av. Las Series','Fiorela4Ever@gmail.com',987951482)
INSERT INTO lector VALUES ('Leonela','Muñoz','Av. Las Estrellas','leo28@gmail.com',988741159)
INSERT INTO lector VALUES ('Andres','Tabur','Av. Las Bermudas','Andew@hotmail.com',963852741)
INSERT INTO lector VALUES ('Rosina','Paredes','Av. Los Postes','rosy@outlook.com',915468357)
INSERT INTO lector VALUES ('Nicole','Hurtado','Av. Los pimientos','Nico@hotmail.com',900396305)
INSERT INTO lector VALUES ('Pamela','Taipe','Av. Buena Vista','taipe@gmail.com',904005987)
GO
SELECT * FROM lector

INSERT INTO prestamo VALUES(2,50,'2017-04-20','2017-05-12',null,'Pendiente')
INSERT INTO prestamo VALUES(1,50,'2017-05-20','2017-05-25',null,'Pendiente')
INSERT INTO prestamo VALUES(3,55,'2017-05-17','2017-05-25',null,'Pendiente')
INSERT INTO prestamo VALUES(4,54,'2017-05-21','2017-06-20',null,'Pendiente')
GO
SELECT * FROM prestamo