CREATE PROCEDURE UpdatePersona
@nro_persona as int, 
@nombre nvarchar(50),
@apellido nvarchar(50),
@fecha_nacimiento datetime,
@sexo nvarchar(10),
@id_profesion int,
@id_nacionalidad int
AS
BEGIN
	UPDATE Persona SET 
	nombre = @nombre,
	apellido = @apellido,
	fecha_nacimiento = @fecha_nacimiento,
	sexo = @sexo,
	id_profesion = @id_profesion,
	id_nacionalidad = @id_nacionalidad
	WHERE nro_persona = @nro_persona
END
