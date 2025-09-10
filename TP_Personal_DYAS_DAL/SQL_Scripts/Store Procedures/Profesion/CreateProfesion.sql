CREATE PROCEDURE CreateProfesion
@descripcion as nvarchar(100)
AS
BEGIN
	INSERT INTO Profesion (id, descripcion)
	VALUES
	((SELECT GREATEST(MAX(id) + 1, 1) FROM Profesion), @descripcion)
END
