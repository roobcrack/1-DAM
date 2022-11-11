//Haz un programa que muestre tantos asteriscos (en la misma línea) como indique el usuario.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n;
		
		Console.WriteLine("Introduzca el numero de asteriscos que desea");
		n = Convert.ToInt32(Console.ReadLine());
		
		while (n > 0){
			Console.Write("*");
			n = n - 1;
		}
	}
}
