//Crea un programa que pida al usuario su contraseña (numérica). 
//Deberá terminar cuando introduzca como contraseña el número 1111, pero 
//volvérsela a pedir tantas veces como sea necesario
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n;
		
		Console.WriteLine("Introduzca la contraseña");
		n = Convert.ToInt32(Console.ReadLine());
	
		while (n != 1111){
			Console.WriteLine("ERROR");
			Console.WriteLine("Vuelva a introducir la contraseña");
			n = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Acceso concedido");
	}
}
