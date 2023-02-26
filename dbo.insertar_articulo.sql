
CREATE PROCEDURE insertar_articulo
(
 @Nombre VARCHAR (124) -- PARAMETROS DE ENTRADA
 , @Precio MONEY
)
AS
BEGIN 
	SET NOCOUNT ON;

		IF (@Nombre IS NULL OR @Nombre NOT LIKE '%[a-z]%') -- SE VALIDA QUE SEAN LETRAS
		BEGIN
			PRINT 'El nombre no es valido' -- EN CASO DE QUE NO, SE IMPRIME UN ERROR
			RETURN;
		END;

		IF (@Precio IS NULL) -- SI EL PARAMETRO ES NULO
		BEGIN
			PRINT 'El precio no es valido'
			RETURN;
		END;

	INSERT INTO dbo.Articulo -- SE INSERTA A LA TABLA EL ARTICULO
	VALUES (@Nombre, @Precio)
	PRINT 'Dato agregado'

	SET NOCOUNT OFF;
END