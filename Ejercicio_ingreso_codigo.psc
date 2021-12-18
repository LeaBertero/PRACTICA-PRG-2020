Proceso sin_titulo
	
	definir codigo, producto como caracter;
	definir precio como real;

	escribir "Ingrese producto:";
	leer producto;
	
	escribir "Presione una tecla para ingresar el codigo del producto ";
	Esperar Tecla;
	
	Limpiar Pantalla;
	
	escribir "Ingrese codigo";
	leer codigo;
	
	Si codigo = "Cod1" Entonces
		escribir "codigo aceptado - presione una tecla";
		esperar tecla;
	SiNo
		Repetir
			escribir "Codigo erroneo - ingrese nuevamente";
			leer codigo;
		Hasta Que codigo = "Cod1";
		
		escribir "Codigo aceptado";
		
	FinSi
	
	escribir "Ingrese el precio del producto";
	leer precio;
	
	Si precio > 0 Entonces
		escribir "Ingreseo correcto - Presione una tecla";
		Esperar Tecla;
		
	SiNo
		Repetir
			escribir "Precio no valido - ingrese nuevamente";
			leer precio;
		Hasta Que precio > 0;
	FinSi
	
	escribir "Continuar con el programa - presione una tecla";
	Esperar Tecla;
	
	
	
FinProceso
