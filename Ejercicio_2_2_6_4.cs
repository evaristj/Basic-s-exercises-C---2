// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de bucles anidados, triangulo de asteriscos
using System;

public class Ejercicio_2_2_6_4{
	
	public static void Main(){
		
		int fila, espacios, ancho, altura; 
		
		Console.Write("Introduce altura de la piramide: ");
		altura = Convert.ToInt32(Console.ReadLine());
	
		for (fila=1; fila <= altura; fila++) { 
			for (espacios=0; espacios < (altura - fila); espacios++){
				Console.Write(" "); 
			}
			for(ancho = 0; ancho < (fila * 2) -1; ancho++){
				Console.Write("*"); 
			}
			Console.WriteLine(); 
		}
	}
	
}
