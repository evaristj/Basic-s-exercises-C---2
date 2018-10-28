// Evarist Jaume - 10/10/2018
// Estructuras repetitivas
// estructura basica de un bucle while

using System;

public class Ejercicio_2_2_1_1_1{
	
	public static void Main(){
	
		int contraseña;
		
		Console.Write("Introduce la contraseña correcta: ");
		contraseña = Convert.ToInt32(Console.ReadLine());
		
		while(contraseña != 1111){
			Console.WriteLine("Contraseña incorrecta, vuelve a intentarlo.");
			contraseña = Convert.ToInt32(Console.ReadLine());
		}
		
		Console.WriteLine("Contraseña correcta!! {0}", contraseña);
		
	}
	
}
