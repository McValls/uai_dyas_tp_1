CREATE PROCEDURE UpdateProfesion
@id as int, @descripcion as nvarchar(100)
AS
BEGIN
	UPDATE Profesion SET Descripcion = @descripcion WHERE Id = @id
END
