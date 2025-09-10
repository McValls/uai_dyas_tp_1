CREATE PROCEDURE CantidadPersonas
AS
BEGIN
	SELECT count(1) as "Cantidad"
	FROM Persona WHERE status != 'Deleted'
END
