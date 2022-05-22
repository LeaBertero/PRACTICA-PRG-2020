Proceso sin_titulo
	
	definir clave como caracter;
	definir salir como entero;
	
	clave <- "clave";
	salir <- 9;
	
	
	
	escribir "Ingrese la clave";
	leer clave;
	
	Repetir
		Mientras clave = "clave" Hacer
			
			Repetir
				escribir "La clave es correcta, aguarde";
				Esperar Tecla;
				escribir "Para salir ingrese 9";
				leer salir;
			Hasta Que salir = 9;
			
		FinMientras
		
		escribir "La clave no es correcta -  ingrese nuevamente";
		leer clave;
	Hasta Que clave = "clave";
	
	escribir "La clave es correcta - presione una tecla para continuar";
	esperar tecla;
FinProceso
