CREATE PROCEDURE listar_articulos

AS
BEGIN 
	SET NOCOUNT ON;

	SELECT Articulo.Id
	, Articulo.Nombre
	, Articulo.Precio
	FROM dbo.Articulo

	SET NOCOUNT OFF;
END