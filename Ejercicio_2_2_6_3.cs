// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de bucles anidados, cuadrado de asteriscos
using System;

public class Ejercicio_2_2_6_3{
	
	public static void Main(){
		
		int fila, columna; 
		int alto, ancho;
		
		// con este bucle garantizamos que alto y ancho sean el mismo valor
		do{
			Console.Write("Introduce el alto del cuadrado: ");
			alto = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Introduce el ancho del cuadrado: ");
			ancho = Convert.ToInt32(Console.ReadLine());
		} while (alto != ancho);
		
		// inicia el bucle para imprimir los asteriscos
		for (fila=1; fila <= alto; fila++) { 
			for (columna=1; columna <= ancho; columna++) 
			Console.Write("*"); 
			Console.WriteLine(); 
		}
	}
	
}
