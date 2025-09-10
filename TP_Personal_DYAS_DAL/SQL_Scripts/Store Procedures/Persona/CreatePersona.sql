CREATE PROCEDURE CreatePersona
@nombre nvarchar(50),
@apellido nvarchar(50),
@fecha_nacimiento datetime,
@sexo nvarchar(10),
@id_profesion int,
@id_nacionalidad int
AS
BEGIN
	INSERT INTO Persona (nro_persona, nombre, apellido, fecha_nacimiento, sexo, id_profesion, id_nacionalidad)
	VALUES
	((SELECT GREATEST(MAX(nro_persona) + 1, 1) FROM Persona), @nombre, @apellido, @fecha_nacimiento, @sexo, @id_profesion, @id_nacionalidad)
END
