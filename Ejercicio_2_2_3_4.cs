// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de uso bucle for
using System;

public class Ejercicio_2_2_3_4{
	
	public static void Main(){
		
		int numero = 9;
		int contador, resultado;
		for (contador=1; contador<=10; contador++){
			resultado = numero * contador;
			Console.WriteLine("{0} * {1} = {2}", numero, contador, resultado);
		}

	}
	
}
