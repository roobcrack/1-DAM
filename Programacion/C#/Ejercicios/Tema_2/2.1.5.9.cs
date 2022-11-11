// Crea un programa que pida al usuario tres números y muestre cuál es el mayor de los tres.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n1, n2, n3;
		
		Console.WriteLine("Introduzca un numero");
		
		n1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Introduzca otro numero");
		
		n2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduzca otro numero");
		
		n3 = Convert.ToInt32(Console.ReadLine());
		
		if ((n1 > n2) && (n1 > n3)){
			Console.WriteLine("El primer numero, " + n1 + ", es el mayor de los 3");
		}
		else if ((n2 > n1) && (n2 > n3)){
			Console.WriteLine("El segundo numero, " + n2 + ", es el mayor de los 3");
		}
		else{
			Console.WriteLine("El tercer numero, " + n3 + ", es el mayor de los 3");
		}
	}
}
