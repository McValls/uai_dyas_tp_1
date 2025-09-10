CREATE PROCEDURE MaximaEdadPersonas
AS
BEGIN
	SELECT MAX(DATEDIFF(YEAR, fecha_nacimiento, GETDATE())
		- case
			WHEN (MONTH(GETDATE()) < MONTH(fecha_nacimiento))
			OR (MONTH(GETDATE()) = MONTH(fecha_nacimiento))
			AND (DAY(GETDATE()) < DAY(fecha_nacimiento))
			THEN 1 ELSE 0
		END) AS "MaximaEdad"
	FROM Persona WHERE status != 'Deleted'
END
