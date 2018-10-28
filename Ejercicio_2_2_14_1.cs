// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// uso del goto
using System;

public class Ejercicio_2_2_14_1{
	
	public static void Main(){
		
		int n1 = 1;
		salida: 
		Console.Write(" {0} ", n1); 
		n1++;
		if(n1 != 11)
			goto salida;
		Console.Write("Fin.");
	}	
}
