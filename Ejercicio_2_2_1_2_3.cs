// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de uso while, calcular cifras de un numero

using System;

public class Ejercicio_2_2_1_2_3{
	
	public static void Main(){
	
		int numero, contador;
		contador = 0;
		Console.Write("Introduce un numero: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		while(numero > 0){
			numero = numero / 10;
			contador++;
		}
		
		Console.Write("El numero tiene {0} cifras.", contador);
	
	}
	
}
