CREATE PROCEDURE GetEdadPersona
@nro_persona as int
AS
BEGIN
	SELECT DATEDIFF(YEAR, fecha_nacimiento, GETDATE())
		- case
			WHEN (MONTH(GETDATE()) < MONTH(fecha_nacimiento))
			OR (MONTH(GETDATE()) = MONTH(fecha_nacimiento))
			AND (DAY(GETDATE()) < DAY(fecha_nacimiento))
			THEN 1 ELSE 0
		END AS "Edad"
	FROM Persona WHERE status != 'Deleted'
	AND nro_persona = @nro_persona
END
