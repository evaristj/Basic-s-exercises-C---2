// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// uso del continue
using System;

public class Ejercicio_2_2_11_2{
	
	public static void Main(){
		
		int n1 = 106;
		
		for (int inicio = 2; inicio < n1; inicio+=2){
			
			if (inicio % 10 == 0)
				continue;
			Console.Write(" {0} ", inicio);				
		}	
	}	
}
