Proceso sin_titulo
	
	definir clave como caracter;
	definir intentos como entero;
	definir nuevaclave como caracter;
	
	
	
	clave <- "caracter";
	nuevaclave <- "";
	
	escribir "Ingrese la clave";
	leer clave;
	
	
	
	Si clave  =  "caracter" Entonces
		escribir "La clave es correcta";
	SiNo
		escribir "Error - Ingrese nuevamente la clave";
		leer clave;
		
		intentos <- 3;
		
		Si intentos = 3 Entonces
			
			escribir "Genere una nueva clave";
			Repetir
				escribir "Ingrese una clave nueva";
				leer nuevaclave;
			Hasta Que nuevaclave = nuevaclave;
			
			escribir "Felicitaciones, se ha modificado la clave -  presione una tecla para seguir";
			esperar tecla;
		SiNo
			escribir "Presione una tecla para salir";
			Esperar Tecla;
		FinSi
	FinSi
	
	escribir "Ha salido del programa";
	
FinProceso
