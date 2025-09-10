CREATE PROCEDURE ProfesionMasPersonas
AS
BEGIN
	SELECT 
		id,
		descripcion
	FROM Profesion WHERE status <> 'Deleted'
	AND id = (select t.id_profesion from 
		(
		SELECT TOP(1) COUNT(1) as contador, id_profesion
		FROM Persona WHERE status <> 'Deleted'
		GROUP BY id_profesion
		order by contador desc) as t
		)
END
