CREATE PROCEDURE DeletePersona
@nro_persona as int
AS
BEGIN
	UPDATE Persona SET Status = 'Deleted' WHERE nro_persona = @nro_persona
END
