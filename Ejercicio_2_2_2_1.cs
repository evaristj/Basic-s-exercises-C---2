// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de uso do while, suma de enteros

using System;

public class Ejercicio_2_2_2_1{
	
	public static void Main(){
		
		int numero, resultado;
		resultado = 0;
		do {
			Console.Write("Introduce numeros positivos: ");
			numero = Convert.ToInt32(Console.ReadLine());
			
			// esta condicion permite salir del bucle introduciendo un 
			// numero negativo sin restarlo al resultado
			if(numero > 0){
				resultado = resultado + numero;
			}
		}
		while (!(numero <= 0));
		
		Console.Write("La suma de los numeros introducidos es: {0}", resultado);
		
	}
	
}
