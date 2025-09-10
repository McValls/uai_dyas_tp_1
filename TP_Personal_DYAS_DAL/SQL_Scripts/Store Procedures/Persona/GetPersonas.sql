CREATE PROCEDURE GetPersonas
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
END
