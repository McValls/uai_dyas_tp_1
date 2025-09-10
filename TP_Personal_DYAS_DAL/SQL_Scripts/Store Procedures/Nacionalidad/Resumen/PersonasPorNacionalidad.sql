CREATE PROCEDURE PersonasPorNacionalidad
AS
BEGIN
	SELECT 
		COUNT(1) as "CantidadPersonas",
		n.id as "id",
		n.descripcion as "descripcion"
	FROM Persona as p 
	INNER JOIN Nacionalidad as n ON p.id_nacionalidad = n.id
	WHERE p.status != 'Deleted'
	GROUP BY n.id, n.descripcion
END
