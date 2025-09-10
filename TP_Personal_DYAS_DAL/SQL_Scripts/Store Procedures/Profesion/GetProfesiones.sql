CREATE PROCEDURE GetProfesiones
AS
BEGIN
	SELECT id, descripcion FROM Profesion WHERE status != 'Deleted'
END
