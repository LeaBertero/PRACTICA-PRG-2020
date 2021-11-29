Proceso sin_titulo
	
	definir clave como caracter;
	definir intentos como entero;
	
	clave <- "Usuario";
	intentos <- 3;
	
	escribir "ingrese clave para ingresar al programa";
	leer clave;
	
	Si clave = "Usuario" Entonces
		Escribir  "La clave es correcta, ingresando al sistema...";
	SiNo
		escribir "Ingrese nuevamente la clave";
		leer clave;
		Si intentos = 3 Entonces
			escribir "Acceso denegado, imposible acceder al programa";
			escribir "Presione una tecla para salir ";
			Esperar Tecla;
		SiNo
			escribir "Ha salido del programa";
		FinSi
	FinSi
	
	
	
	
FinProceso
