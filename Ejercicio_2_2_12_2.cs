// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// equivalencia for y while
using System;

public class Ejercicio_2_2_12_2{
	
	public static void Main(){
		
		int n1 = 10;
		
		for (int inicio = 20; inicio >= n1; inicio-=2){
			if (inicio == 14)
				continue;
			Console.Write(" {0} ", inicio);				
		}	
		Console.WriteLine();
		int init = 20;
		while(init >= n1){
			
			if (init == 14)
				continue;
				
			Console.Write(" {0} ", init);	
			init-=2;
		}
	}	
}
