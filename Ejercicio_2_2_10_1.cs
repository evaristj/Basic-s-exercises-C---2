// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// maximo comun divisor con break en for
using System;

public class Ejercicio_2_2_10_1{
	
	public static void Main(){
		
		int n1, n2;
		
		Console.Write("Introduce un numero: ");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduce otro numero: ");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		for (int mcd = 1; mcd < n1; mcd++){
		
			if ((n1 % mcd == 0) && (n2 % mcd == 0)){
				break;				
			}
		}	
	}	
}
