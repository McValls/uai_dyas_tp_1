CREATE PROCEDURE GetNacionalidades
AS
BEGIN
	SELECT id, descripcion FROM Nacionalidad where status != 'Deleted'
END
