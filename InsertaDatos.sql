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
 ('Transacciones','\Iconos\transaccion.png'),
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

  --MENU TRANSACCIONES
 INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Regristro Prestamo','NuevoPrestamo'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Libros Prestados','LibrosPrestados'),
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Transacciones'),'Libros Devueltos','LibrosDevueltos')
GO


--MENU LIBROS
INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Libros'),'Mostrar Libros','Libros')
GO

--MENU LECTOR
INSERT INTO SUBMENU(IdMenu,Nombre,NombreFormulario) VALUES
 ((SELECT IdMenu FROM MENU WHERE Nombre = 'Lector'),'Mostrar Lector','Lector')
  SELECT * FROM SUBMENU

--INSERTAR USUARIO
INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave)
VALUES('Alvin','Gutierrez',(SELECT TOP 1 IdRol FROM ROL WHERE Descripcion = 'ADMINISTRADOR'),'alvin2020','Managua2022')
GO

INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave)
VALUES('Emely','Flores',(SELECT TOP 1 IdRol FROM ROL WHERE Descripcion = 'BIBLIOTECARIO'),'emely2020','Sistemas123')
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

INSERT INTO libros VALUES ('Los perros y la ciudad',4,1,1,'Seccion L',100,5,1999)
INSERT INTO libros VALUES ('Cien Años de Soledad',4,1,4,'Seccion C',80,3,2000)
INSERT INTO libros VALUES ('La Fiesta del Chivo',4,4,5,'Seccion L',90,4,1995)
INSERT INTO libros VALUES ('Yo el Sumpremo',6,4,6,'Seccion Y',95,6,2001)
INSERT INTO libros VALUES ('La Guerra del Fin del Mundo',5,5,5,'Seccion L',75,1,2003)
INSERT INTO libros VALUES ('La Muerte de Artemio Cruz',6,1,7,'Seccion L',96,7,2004)
INSERT INTO libros VALUES ('Como Agua para Chocolate',7,6,7,'Seccion C',84,2,1998)
INSERT INTO libros VALUES ('Los Heraldos Negros',1,6,8,'Seccion L',56,6,2000)
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

INSERT INTO prestamo VALUES(2,1,'2022-11-20','2022-11-28','2022-11-22','Entregado')
INSERT INTO prestamo VALUES(3,2,'2022-11-18','2022-11-22','2022-11-20','Entregado')
INSERT INTO prestamo VALUES(4,3,'2022-11-20','2022-11-30','2022-11-25','Entregado')
INSERT INTO prestamo VALUES(5,4,'2022-05-21','2022-05-28','2022-05-25','Entregado')
GO
SELECT * FROM prestamo

delete from prestamo --Sirve para borrar los registros de una tabla determinada