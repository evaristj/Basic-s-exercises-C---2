// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de uso bucle for
using System;

public class Ejercicio_2_2_3_3{
	
	public static void Main(){
		
		int contador;
		for (contador=100; contador<=200; contador++){
			if((contador % 3 == 0) && (contador % 7 == 0))
				Console.Write("{0} ", contador);
		}

	}
	
}
