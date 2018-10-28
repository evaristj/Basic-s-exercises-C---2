// Evarist Jaume - 14/10/2018
// Estructuras repetitivas
// Ejemplos de uso while

using System;

public class Ejercicio_2_2_1_1_4{
	
	public static void Main(){
	
		int numeroA, numeroB;
		
		Console.Write("Introduce un numero par o cero para salir: ");
		numeroA = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce otro numero par o cero para salir: ");
		numeroB = Convert.ToInt32(Console.ReadLine());
		
		while((numeroB != 0) && (numeroA != 0)){
			if (numeroA % 2 != 0){
				Console.Write("Numero {0} no es par, introduce otro o cero para salir: ", numeroA);
				numeroA = Convert.ToInt32(Console.ReadLine());
			}
			if (numeroB % 2 != 0){
				Console.Write("Numero {0} no es par, introduce otro o cero para salir: ", numeroB);
				numeroB = Convert.ToInt32(Console.ReadLine());
			}
			
			if (numeroA % numeroB == 0){
				Console.WriteLine("El numero {0} es multiplo del numero {1}.", numeroA, numeroB);
			}else if (numeroB % numeroA == 0){
				Console.WriteLine("El numero {0} es multiplo del numero {1}.", numeroB, numeroA);
			}else if (!(numeroA % numeroB == 0) && !(numeroB % numeroA == 0)){
				Console.WriteLine("El numero {0} no es multiplo del numero {1} y viceversa.", numeroB, numeroA);
			}
			
			Console.Write("Introduce un numero par o cero para salir: ");
			numeroA = Convert.ToInt32(Console.ReadLine());
		
			Console.Write("Introduce otro numero par o cero para salir: ");
			numeroB = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Has introducido un cero, fin del programa.");	
		
	}
	
}
