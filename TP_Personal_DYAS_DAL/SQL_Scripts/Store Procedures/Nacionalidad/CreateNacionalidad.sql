CREATE PROCEDURE CreateNacionalidad
@descripcion as nvarchar(100)
AS
BEGIN
	INSERT INTO Nacionalidad (id, descripcion)
	VALUES
	((SELECT GREATEST(MAX(id) + 1, 1) FROM Nacionalidad), @descripcion)
END
