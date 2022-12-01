USE Biblioteca
GO

/*PROCEDIMIENTOS PARA MENUPRINCIPA,ROL,USUARIO e PERMISOS */
--PROCEDMIENTO PARA OBTENER ROLES
CREATE PROC ObtenerRoles
as
begin
 select IdRol, Descripcion,Activo from ROL
end

GO

--PROCEDIMIENTO PARA GUARDAR ROL
CREATE PROC RegistrarRol(
@Descripcion varchar(50),
@Resultado bit output
)as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM ROL WHERE Descripcion = @Descripcion)
	begin
		declare @idrol int = 0
		insert into ROL(Descripcion) values (
		@Descripcion
		)
		set @idrol  = Scope_identity()

		insert into PERMISOS(IdRol,IdSubMenu,Activo)
		select @idrol, IdSubMenu,0 from SUBMENU
	end
	ELSE
		SET @Resultado = 0
	
end

GO

--PROCEDIMIENTO PARA MODIFICAR ROLES
CREATE PROC ModificarRol(
@IdRol int,
@Descripcion varchar(60),
@Activo bit,
@Resultado bit output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM ROL WHERE Descripcion =@Descripcion and IdRol != @IdRol)
		
		update ROL set 
		Descripcion = @Descripcion,
		Activo = @Activo
		where IdRol = @IdRol
	ELSE
		SET @Resultado = 0

end

GO

--PROCEDIMIENTO PARA ELIMINAR ROL
CREATE PROC EliminarRol(
@IdRol int,
@Resultado bit output
)
as
begin
	SET @Resultado = 1

	--validamos que el rol no se encuentre asignado a algun usuario
	IF not EXISTS (select * from USUARIO u
	inner join ROL r on r.IdRol  = u.IdRol
	where r.IdRol = @IdRol)
	begin	
		delete from PERMISOS where IdRol = @IdRol
		delete from ROL where IdRol = @IdRol
	end
	ELSE
		SET @Resultado = 0

end
GO


--PROCEDMIENTO PARA OBTENER PERMISOS
CREATE PROC ObtenerPermisos(
@IdRol int)
as
begin
select p.IdPermisos,m.Nombre[Menu],sm.Nombre[SubMenu],p.Activo from PERMISOS p
inner join SUBMENU sm on sm.IdSubMenu = p.IdSubMenu
inner join MENU m on m.IdMenu = sm.IdMenu
where p.IdRol = @IdRol
end

GO

--PROCEDIMIENTO PARA ACTUALIZAR PERMISOS
CREATE PROC ActualizarPermisos(
@Detalle xml,
@Resultado bit output
)
as
begin
begin try

	BEGIN TRANSACTION
	declare @permisos table(idpermisos int,activo bit)

	insert into @permisos(idpermisos,activo)
	select 
	idpermisos = Node.Data.value('(IdPermisos)[1]','int'),
	activo = Node.Data.value('(Activo)[1]','bit')
	FROM @Detalle.nodes('/DETALLE/PERMISO') Node(Data)

	select * from @permisos

	update p set p.Activo = pe.activo from PERMISOS p
	inner join @permisos pe on pe.idpermisos = p.IdPermisos

	COMMIT
	set @Resultado = 1

end try
begin catch
	ROLLBACK
	set @Resultado = 0
end catch
end

GO

--PROCEDMIENTO PARA OBTENER USUARIOS
CREATE PROC ObtenerUsuario
as
begin
 select u.IdUsuario,u.Nombres,u.Apellidos,u.LoginUsuario,u.LoginClave,u.IdRol,u.Activo,r.Descripcion[DescripcionRol],u.Activo from USUARIO u
 inner join ROL r on r.IdRol = u.IdRol
end

GO

--PROCEDMIENTO PARA OBTENER USUARIO

CREATE PROC LoginUsuario(
@Usuario varchar(60),
@Clave varchar(60),
@IdUsuario int output
)
as
begin
	set @IdUsuario = 0
	if exists(select * from USUARIO where [LoginUsuario] COLLATE Latin1_General_CS_AS = @Usuario and LoginClave COLLATE Latin1_General_CS_AS = @Clave and Activo = 1)
		set @IdUsuario = (select top 1 IdUsuario from USUARIO where [LoginUsuario]  COLLATE Latin1_General_CS_AS = @Usuario and LoginClave COLLATE Latin1_General_CS_AS = @Clave and Activo = 1)
end

GO

--PROCEDIMIENTO PARA REGISTRAR USUARIO
CREATE PROC RegistrarUsuario(
@Nombres varchar(50),
@Apellidos varchar(50),
@IdRol int,
@Usuario varchar(50),
@Clave varchar(50),
@Resultado bit output
)AS
BEGIN
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM USUARIO WHERE LoginUsuario = @Usuario)

		INSERT INTO USUARIO(Nombres,Apellidos,IdRol,LoginUsuario,LoginClave) VALUES (
		@Nombres,@Apellidos,@IdRol,@Usuario,@Clave)
	ELSE
		SET @Resultado = 0
	
END
GO

--PROCEDIMIENTO PARA MODIFICAR USUARIO
CREATE PROC ModificarUsuario(
@IdUsuario int,
@Nombres varchar(50),
@Apellidos varchar(50),
@IdRol int,
@Usuario varchar(50),
@Clave varchar(50),
@Resultado bit output
)
as
begin
	SET @Resultado = 1
	IF NOT EXISTS (SELECT * FROM USUARIO WHERE LoginUsuario = @Usuario and IdUsuario != @IdUsuario)
		
		update USUARIO set 
		Nombres = @Nombres,
		Apellidos = @Apellidos,
		IdRol = @IdRol,
		LoginUsuario = @Usuario,
		LoginClave = @Clave
		where IdUsuario = @IdUsuario

	ELSE
		SET @Resultado = 0

end

GO

--PROCEDIMIENTO PARA ELIMINAR USUARIO
CREATE PROC EliminarUsuario(
@IdUsuario int,
@Resultado bit output
)
as
begin

	delete from USUARIO where IdUsuario = @IdUsuario
	SET @Resultado = 1
end

GO

--PROCEDMIENTO PARA OBTENER DETALLE USUARIO
CREATE PROC ObtenerDetalleUsuario(
@IdUsuario int
)
as
begin
 select *,
(select * from ROL r
 where r.IdRol = up.IdRol
FOR XML PATH (''),TYPE) AS 'DetalleRol'
,
 (
 select t.NombreMenu,t.Icono,
 (select sm.Nombre[NombreSubMenu],sm.NombreFormulario,p.Activo
	 from PERMISOS p
	 inner join ROL r on r.IdRol = p.IdRol
	 inner join SUBMENU sm on sm.IdSubMenu = p.IdSubMenu
	 inner join MENU m on m.IdMenu = sm.IdMenu
	 inner join USUARIO u on u.IdRol = r.IdRol and u.IdUsuario = up.IdUsuario
	where sm.IdMenu = t.IdMenu
  FOR XML PATH ('SubMenu'),TYPE) AS 'DetalleSubMenu' 

 from (
 select distinct m.Nombre[NombreMenu],m.IdMenu,m.Icono
 from PERMISOS p
 inner join ROL r on r.IdRol = p.IdRol
 inner join SUBMENU sm on sm.IdSubMenu = p.IdSubMenu
 inner join MENU m on m.IdMenu = sm.IdMenu
 inner join USUARIO u on u.IdRol = r.IdRol and u.IdUsuario = up.IdUsuario
 where p.Activo = 1) t
 FOR XML PATH ('Menu'),TYPE) AS 'DetalleMenu'  
 from USUARIO up
 where UP.IdUsuario = @IdUsuario
 FOR XML PATH(''), ROOT('Usuario')  

end

GO

  /*---------------------------------------------PROCEDIMIENTOS PARA LECTOR---------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR LECTORES SEGUN FILTROS*/
 /*PROCEDIMIENTO PARA VERIFICAR LECTORES*/
 CREATE PROC VerificarLector
 @codlector int
 AS
 BEGIN
	select * from prestamo where Fec_Devolucion < GETDATE() and Estado = 'Pendiente' and CodLector = @codlector
 END
 GO

 /*PROCEDIMIENTO PARA MOSTRAR LECTORES*/
 CREATE PROC MostrarLectores
 AS
 BEGIN

	SELECT CodLector, Nombres, Apellidos,Direccion,Email,Telefono FROM lector order by CodLector desc
 END
 GO
  
 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR LECTOR*/
 CREATE PROC AgregarLector
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int
 AS
 BEGIN
 INSERT INTO lector VALUES (@nombres,@apellidos,@direccion,@email,@telefono)
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR LECTOR*/
 CREATE PROC ModificarLector
 @codlector int,
 @nombres varchar(50),
 @apellidos varchar(50),
 @direccion varchar(100),
 @email varchar(60),
 @telefono int
 AS
 BEGIN
 UPDATE lector SET Nombres = @nombres, Apellidos = @apellidos, Direccion = @direccion, Email= @email, Telefono = @telefono
 WHERE Codlector = @codlector
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR LECTOR*/
  CREATE PROC EliminarLector
  @codlector int
  AS
  BEGIN
  DELETE FROM lector WHERE CodLector = @codlector
  END
  GO

  /*----------------------------------------PROCEDIMIENTOS PARA AUTOR--------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA AUTORES SEGUN FILTROS*/
 CREATE PROC MostrarAutor
 AS
 BEGIN

	SELECT CodAutor as Codigo, Autor FROM autor ORDER BY CodAutor desc
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR AUTOR*/
 CREATE PROC AgregarAutor
 @autor varchar(50)
 AS
 BEGIN
 INSERT INTO autor VALUES (@autor)
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR AUTOR*/
 CREATE PROC ModificarAutor
 @codautor int,
 @autor varchar(50)
 AS
 BEGIN
 UPDATE autor SET Autor = @autor
 WHERE CodAutor = @codautor
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR AUTOR*/
  CREATE PROC EliminarAutor
  @codautor int
  AS
  BEGIN
  DELETE FROM autor WHERE CodAutor = @codautor
  END
  GO

     /*-------------------------------------PROCEDIMIENTOS PARA GENERO---------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA GENEROS SEGUN FILTROS*/
 CREATE PROC MostrarGenero
 AS
 BEGIN

	SELECT CodGenero as Codigo, Genero FROM genero order by CodGenero desc
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR GENERO*/
 CREATE PROC AgregarGenero
 @genero varchar(50)
 AS
 BEGIN
 INSERT INTO genero VALUES (@genero)
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR GENERO*/
 CREATE PROC ModificarGenero
 @codgenero int,
 @genero varchar(50)
 AS
 BEGIN
 UPDATE genero SET Genero = @genero
 WHERE CodGenero = @codgenero
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR GENERO*/
  CREATE PROC EliminarGenero
  @codgenero int
  AS
  BEGIN
  DELETE FROM genero WHERE CodGenero = @codgenero
  END
  GO

     /*--------------------------------------------PROCEDIMIENTOS PARA EDITORIAL----------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA EDITORIAL SEGUN FILTROS*/
 CREATE PROC MostrarEditorial
 AS
 BEGIN
	SELECT CodEditorial as Codigo, Editorial FROM editorial ORDER BY CodEditorial DESC
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR Editorial*/
 CREATE PROC AgregarEditorial
 @editorial varchar(50)
 AS
 BEGIN
 INSERT INTO editorial VALUES (@editorial)
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR EDITORIAL*/
 CREATE PROC ModificarEditorial
 @codeditorial int,
 @editorial varchar(50)
 AS
 BEGIN
 UPDATE editorial SET Editorial = @editorial
 WHERE CodEditorial = @codeditorial
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR EDITORIAL*/
  CREATE PROC EliminarEditorial
  @codeditorial int
  AS
  BEGIN
  DELETE FROM editorial WHERE CodEditorial = @codeditorial
  END
  GO	
  
   /*--------------------------------------------PROCEDIMIENTOS PARA LIBROS------------------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR LIBROS SEGUN FILTROS*/
 CREATE PROC MostrarLibros
 AS
 BEGIN
	SELECT LI.CodLibro, LI.Titulo,AU.CodAutor, AU.Autor, GE.CodGenero, GE.Genero, ED.CodEditorial, ED.Editorial, LI.Ubicacion, LI.Cantidad,LI.NroEdicion,LI.AñoEdicion
	FROM libros LI
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	INNER JOIN genero GE ON GE.CodGenero = LI.CodGenero
	INNER JOIN editorial ED ON ED.CodEditorial = LI.CodEditorial
	order by LI.CodLibro DESC
 END
 GO

 /*-----------------------PROCEDIMIENTO ALMACENADO PARA LOS REPORTES DE LOS LIBROS---------------------------------*/
 ALTER PROC ReporteLibros
 @busqueda varchar(100)
 AS
 BEGIN
	SELECT LI.CodLibro, LI.Titulo,AU.Autor, GE.Genero, ED.Editorial, LI.Ubicacion, LI.Cantidad,LI.NroEdicion,LI.AñoEdicion
	FROM libros LI
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	INNER JOIN genero GE ON GE.CodGenero = LI.CodGenero
	INNER JOIN editorial ED ON ED.CodEditorial = LI.CodEditorial
	WHERE LI.Titulo like @busqueda +'%' OR
	AU.Autor like @busqueda +'%' OR
	GE.Genero LIKE @busqueda +'%' OR
	ED.Editorial LIKE @busqueda +'%'
 END
 GO
 
  /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR STOCK DE LIBROS SEGUN FILTROS*/
 CREATE PROC MostrarLibrosStock
 as
 begin
	SELECT LI.CodLibro AS Codigo, LI.Titulo, AU.Autor, SL.Disponibles FROM stocklibros SL
	INNER JOIN libros LI on LI.CodLibro = SL.CodLibro
	INNER JOIN autor AU ON AU.CodAutor = LI.CodAutor
	order by LI.CodLibro DESC
 end
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR STOCK DEL LIBRO*/
 CREATE PROC VerificarLibro
 @codlibro INT
 as
 begin
	select Disponibles from stocklibros where Codlibro = @codlibro
 end
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR LA CANTIDAD DISPONIBLE*/
 CREATE PROC VerificarCantidadLibro
 @codlibro INT
 as
 begin
	select * from prestamo where Codlibro = @codlibro and Estado = 'Pendiente'
 end
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR LIBRO*/
 CREATE PROC AgregarLibro
 @titulo varchar(50),
 @codautor int,
 @codgenero int,
 @codeditorial int,
 @ubicacion varchar(50),
 @cantidad int,
 @nroEdicion int,--Esperando...
 @añoEdicion int
 AS
 BEGIN
 INSERT INTO libros VALUES (@titulo,@codautor,@codgenero,@codeditorial,@ubicacion,@cantidad,@nroEdicion,@añoEdicion)
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR LIBRO*/
 CREATE PROC ModificarLibro
 @codlibro int,
 @titulo varchar(50),
 @codautor int,
 @codgenero int,
 @codeditorial int,
 @ubicacion varchar(50),
 @cantidad int,
 @nroEdicion int,--Esperando...
 @añoEdicion int
 AS
 BEGIN
 UPDATE libros SET Titulo = @titulo, CodAutor = @codautor, CodGenero = @codgenero, CodEditorial = @codeditorial, Ubicacion = @ubicacion, Cantidad = @cantidad, NroEdicion = @nroEdicion, AñoEdicion = @añoEdicion
 WHERE Codlibro = @codlibro
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA ELIMINAR LIBRO*/
  CREATE PROC EliminarLibro
  @codlibro int
  AS
  BEGIN
  DELETE FROM libros WHERE CodLibro = @codlibro
  END
  GO

  /*-------------------------------------------PROCEDIMIENTOS PARA PRESTAMO----------------------------------------------*/
 /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR PRESTAMOS SEGUN FILTROS*/
 CREATE PROC MostrarPrestamo
 AS
 BEGIN
	SELECT PR.CodPrestamo AS 'Nro Registro',(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Fec_Retorno, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Pendiente'
	order by PR.CodPrestamo desc
 END
 GO

 /*......................CREAMOS LA VISTA PARA EL REPORTE......................*/
 CREATE PROC ReportePrestamos
 @busqueda varchar(100)
 AS
 BEGIN
 	SELECT PR.CodPrestamo,(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Pendiente' and
	(LI.Titulo like @busqueda + '%' OR LE.Nombres like @busqueda +'%' OR LE.Apellidos like @busqueda +'%')
 END
 GO

  /*CREAMOS UN PROCEDIMIENTO PARA MOSTRAR PRESTAMOS DEVUELTOS SEGUN FILTROS*/
 CREATE PROC MostrarPrestamoDevueltos
 AS
 BEGIN
	SELECT PR.CodPrestamo AS 'Nro Registro',(LE.Nombres + ' ' + LE.Apellidos) AS Lector , LI.Titulo , PR.Fec_Entrega, PR.Fec_Devolucion, PR.Fec_Retorno, PR.Estado FROM prestamo PR
	INNER JOIN lector LE on LE.CodLector = PR.CodLector
	INNER JOIN libros LI on LI.CodLibro = PR.CodLibro
	WHERE PR.Estado = 'Retornado'
	order by PR.CodPrestamo desc
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA VERIFICAR PRESTAMOS POR LECTOR*/
 CREATE PROC MostrarPrestamoDeudaLecor
 @codlector int
 AS
 BEGIN
	select (LE.Nombres + ' ' + LE.Apellidos) as Lector, LI.Titulo, PR.Fec_Entrega, Fec_Devolucion, PR.Estado from prestamo PR
	inner join lector LE on LE.CodLector = PR.CodLector
	inner join libros LI on LI.CodLibro = PR.CodLibro
	where Fec_Devolucion < GETDATE() and PR.Estado = 'Pendiente' and PR.CodLector = @codlector
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA AGREGAR PRESTAMO*/
 CREATE PROC AgregarPrestamo
 @codlector int,
 @codlibro int,
 @fec_devolucion date
 AS
 BEGIN
 declare @fe date
 set @fe = getdate()
 INSERT INTO prestamo VALUES (@codlector,@codlibro,@fe,@fec_devolucion,null,'Pendiente')
 END
 GO

 /*CREAMOS UN PROCEDIMIENTO PARA MODIFICAR PRESTAMO*/
 CREATE PROC ModificarPrestamoRetorno
 @codprestamo int
 AS
 BEGIN
 declare @fe date
 set @fe = getdate()
 UPDATE prestamo SET Fec_Retorno = @fe, Estado = 'Retornado'
 WHERE CodPrestamo = @codprestamo
 END
 GO
/*EL PRESTAMO NO SE ELIMINARÁ DE LOS REGISTROS*/

/*------------------------------------------------CREACION DE TRIGGERS-----------------------------------------------*/
/*AHORA CREAREMOS UN TRIGGER PARA ALMACENAR AUTOMATICAMENTE EN LA TABLA stocklibros CADA VEZ QUE SE ALMACENE UN LIBRO*/
CREATE TRIGGER AgregarStockNuevo ON libros
AFTER INSERT 
AS
BEGIN
DECLARE @codlibro int
set @codlibro = (SELECT TOP 1 CodLibro FROM libros ORDER BY CodLibro DESC)

DECLARE @cantidad int
set @cantidad = (SELECT Cantidad from libros where CodLibro = @codlibro)
INSERT INTO stocklibros VALUES (@codlibro, @cantidad)
END
GO

/*AHORA CREAMO UN TRIGGER PARA DISMINUIR EL STOCK DE LIBROS CADA VEZ QUE OCURRA UN PRESTAMO*/
CREATE TRIGGER DisminuirStocklibro ON prestamo
AFTER INSERT 
AS
BEGIN
DECLARE @codlibro int
set @codlibro = (SELECT Codlibro from inserted)
UPDATE stocklibros SET Disponibles = (Disponibles - 1) WHERE CodLibro = @codlibro
END
GO

/*AHORA CREAMOS UN TRIGGER PARA AUMENTAR EL STOCK DE LIBROS CADA VEZ QUE OCURRA QUE SE DEVUELVA UN PRESTAMO*/
CREATE TRIGGER AumentarStocklibro ON prestamo
AFTER UPDATE 
AS
BEGIN
Declare @codlibro int
set @codlibro = (select codlibro from inserted)
UPDATE stocklibros SET Disponibles = (Disponibles + 1) WHERE CodLibro = @codlibro
END
GO
