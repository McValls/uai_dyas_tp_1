CREATE PROCEDURE PromedioEdadPorNacionalidad
AS
BEGIN
	SELECT AVG(DATEDIFF(YEAR, fecha_nacimiento, GETDATE())
		- case
			WHEN (MONTH(GETDATE()) < MONTH(fecha_nacimiento))
			OR (MONTH(GETDATE()) = MONTH(fecha_nacimiento))
			AND (DAY(GETDATE()) < DAY(fecha_nacimiento))
			THEN 1 ELSE 0
		END) AS "PromedioEdad",
		n.id as "id",
		n.descripcion as "descripcion"
	FROM Persona as p 
	INNER JOIN Nacionalidad as n ON p.id_nacionalidad = n.id
	WHERE p.status != 'Deleted'
	GROUP BY n.id, n.descripcion
END
