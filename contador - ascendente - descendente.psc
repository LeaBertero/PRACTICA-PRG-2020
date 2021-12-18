Proceso sin_titulo
	
	definir contador, opcion como entero;
	definir mov como entero;
	
	Repetir
		escribir "Presione una tecla para iniciar conteo del 1 al 10";
		esperar tecla;
		
		Limpiar Pantalla;
		escribir "Contador ascendente";
		
		Para contador <- 0 Hasta 0 Con Paso 1 Hacer
			escribir "1";
			Esperar Tecla;
			escribir "2";
			Esperar Tecla;
			escribir "3";
			Esperar Tecla;
			escribir "4";
			Esperar Tecla;
			escribir "5";
			Esperar Tecla;
			escribir "6";
			Esperar Tecla;
			escribir "7";
			Esperar Tecla;
			escribir "8";
			Esperar Tecla;
			escribir "9";
			Esperar Tecla;
			escribir "10";
			Esperar Tecla;
		FinPara
		
		Limpiar Pantalla;
		escribir "Contador descendente";
		
		Para contador <- 0 Hasta 0 Con Paso 1 Hacer
			escribir "10";
			Esperar Tecla;
			escribir "9";
			Esperar Tecla;
			escribir "8";
			Esperar Tecla;
			escribir "7";
			Esperar Tecla;
			escribir "6";
			Esperar Tecla;
			escribir "5";
			Esperar Tecla;
			escribir "4";
			Esperar Tecla;
			escribir "3";
			Esperar Tecla;
			escribir "2";
			Esperar Tecla;
			escribir "1";
			Esperar Tecla;
			Limpiar Pantalla;
			escribir "Ha finalizado - presione una tecla";
			Esperar Tecla;
			
			escribir "Salir del programa - ingrese 2";
			leer opcion;
		FinPara
	Hasta Que opcion = 2;
	
	escribir "Ha salido del programa";
	
	
	
FinProceso
