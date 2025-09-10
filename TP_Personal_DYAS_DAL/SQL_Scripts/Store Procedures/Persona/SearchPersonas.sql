CREATE PROCEDURE SearchPersonas
@nro_persona	int		=	NULL
AS
BEGIN
	SELECT nro_persona, 
		nombre, 
		apellido, 
		fecha_nacimiento, 
		sexo, 
		id_profesion, 
		id_nacionalidad 
	FROM Persona WHERE status != 'Deleted'
	AND (@nro_persona IS NULL OR nro_persona = @nro_persona)
END
