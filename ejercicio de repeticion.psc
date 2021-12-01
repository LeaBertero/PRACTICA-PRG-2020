Proceso sin_titulo
	
	DEFINIR D1,D2, D3, D4,D5 COMO caracter;
	definir salir como caracter;
	
	salir <- "Salir";
	
	D1 <- "Hoy es lunes - primer dia de la semana";
	D2 <- "- Hoy es lunes - primer dia de la semana";
	D3 <- "-- Hoy es lunes - primer dia de la semana";
	D4 <- "--- Hoy es lunes - primer dia de la semana";
	D5 <- "---- Hoy es lunes - primer dia de la semana ";
	
	Repetir
		escribir D1;
		escribir D2;
		escribir D3;
		escribir D4;
		escribir D5;
		escribir "";
		escribir D5;
		escribir D4;
		escribir D3;
		escribir D2;
		escribir D1;
		escribir "";
		escribir "Para salir , escriba (Salir)";
		leer salir;
	Hasta Que salir = "Salir";
	
	ESCRIBIR "Presione una tecla";
	esperar tecla;
	
FinProceso
