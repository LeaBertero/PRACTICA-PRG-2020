Proceso sin_titulo
	
	definir hora, min, seg como entero;
	
	//hora <- 00;
	//min <- 00;
	//seg <- 00;
	
	escribir "presione una tecla para iniciar la hora";
	esperar tecla;
	Limpiar Pantalla;
	
	escribir "Iniciando conteo de horas...";
	//escribir "";
	Para hora <- 0 Hasta 23 Con Paso 1 Hacer
		escribir hora, " ", "Horas";
		esperar tecla;
	FinPara
	
	Limpiar Pantalla;
	
	escribir "Ha finalizado el conteo de las horas, presione una tecla para iniciar el conteo de minutos";
	esperar tecla;
	Limpiar Pantalla;
	
	escribir "Iniciando conteo de minutos...";
	min <- 0;
	//escribir "";
	
	Para min <- 0 Hasta 59 Con Paso 1 Hacer
		escribir min, " ", "Minutos";
		esperar tecla;
	FinPara
	
	Limpiar Pantalla;
	
	escribir "Ha finalizado el conteo de las minutos, presione una tecla para iniciar el conteo de segundos";
	esperar tecla;
	Limpiar Pantalla;
	
	escribir "Iniciando conteo de segundos...";
	//escribir "";
	Para seg <- 0 Hasta 59 Con Paso 1 Hacer
		escribir seg, " ", "Segundos";
		esperar tecla;
	FinPara
	
	escribir "Ha finalizado el cronometro - presione una tecla para salir";
	esperar tecla;
	
FinProceso
