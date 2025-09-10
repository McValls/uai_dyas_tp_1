CREATE PROCEDURE DeleteNacionalidad
@id as int
AS
BEGIN
	UPDATE Nacionalidad SET status = 'Deleted' WHERE Id = @id
END
