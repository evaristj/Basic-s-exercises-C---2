// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de bucles anidados
using System;

public class Ejercicio_2_2_5_2{
	
	public static void Main(){
		
		int n1 = 1;
		int n2;
		while (n1 <= 4){
			for (n2=1; n2<=5; n2++) {
				Console.Write("{0}", n2);
			}
			n1++;
		}
	}
	
}
