//Crea un programa que halle (y muestre) la raíz cuadrada del número que 
//introduzca el usuario. Se repetirá hasta que introduzca 0.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double n;
		
		Console.WriteLine("Introduzca un numero para calcular su raiz cuadrada");
		n = Convert.ToDouble(Console.ReadLine());
		
		while (n != 0){
			Console.WriteLine("La raiz cuadrada de {0} es: " + Math.Sqrt(n), n);
		
			Console.WriteLine("Introduzca un numero para calcular su raiz cuadrada");
			n = Convert.ToDouble(Console.ReadLine());
		}
	}
}
