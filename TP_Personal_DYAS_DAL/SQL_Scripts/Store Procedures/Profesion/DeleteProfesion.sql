CREATE PROCEDURE DeleteProfesion
@id as int
AS
BEGIN
	Update Profesion set status = 'Deleted' WHERE Id = @id
END
