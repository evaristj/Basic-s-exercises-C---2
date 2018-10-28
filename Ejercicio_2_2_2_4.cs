// Evarist Jaume - 15/10/2018
// Estructuras repetitivas
// Ejemplos de uso do while

using System;

public class Ejercicio_2_2_2_4{
	
	public static void Main(){
		
		int usuario = 1234; 
		int contraseña = 1111;
		int pass, id;
		do { 
			Console.Write("Introduzca su usuario: "); 
			id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Introduzca su contraseña: "); 
			pass = Convert.ToInt32(Console.ReadLine());
			
			if (id != usuario || pass != contraseña) {
			Console.WriteLine("Datos incorrectos."); 
			}
		} while (id != usuario || contraseña != pass);
		
		Console.WriteLine("Aceptada.");

	}
	
}
