CREATE PROCEDURE UpdateNacionalidad
@id as int, @descripcion as nvarchar(100)
AS
BEGIN
	UPDATE Nacionalidad SET Descripcion = @descripcion WHERE Id = @id
END
