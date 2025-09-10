CREATE PROCEDURE NacionalidadMasPersonas
AS
BEGIN
	SELECT 
		id,
		descripcion
	FROM Nacionalidad WHERE status <> 'Deleted'
	AND id = (select t.id_nacionalidad from 
		(
		SELECT TOP(1) COUNT(1) as contador, id_nacionalidad
		FROM Persona WHERE status <> 'Deleted'
		GROUP BY id_nacionalidad
		order by contador desc) as t
		)
END
