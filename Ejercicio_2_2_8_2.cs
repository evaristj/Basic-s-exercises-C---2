// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// declarar variables en un for
using System;

public class Ejercicio_2_2_8_2{
	
	public static void Main(){
		
		int alto, ancho;
		
		Console.Write("Introduce el alto del cuadrado: ");
		alto = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce el ancho del cuadrado: ");
		ancho = Convert.ToInt32(Console.ReadLine());
	
		// inicia el bucle para imprimir los asteriscos
		for (int filaActual=1; filaActual <= alto; filaActual++) { 
			for (int columnaActual=1; columnaActual <= ancho; columnaActual++){ 
				Console.Write("*"); 
			}
			Console.WriteLine(); 
		}
	}
	
}
