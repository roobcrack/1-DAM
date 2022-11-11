//  Crea un programa que pida al usuario dos números enteros y diga si uno y sólo uno es par
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n1, n2;
		
		Console.WriteLine("Introduzca un numero");
		
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduzca otro numero");
		
		n2 = Convert.ToInt32(Console.ReadLine());
		
		if (((n1 % 2 != 0) && (n2 % 2 == 0)) || ((n1 % 2 == 0) && (n2 % 2 != 0))){
				Console.WriteLine("Uno de ellos es par");
		}
		else{
			Console.WriteLine("O ambos son pares, o ambos son impares");
		}
	}
}
