//Crea un "calculador de cuadrados": pedirá al usuario un número y 
//mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero
//(usa "while" para conseguirlo).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n, r;
		
		Console.WriteLine("Introduzca un numero para calcular su cuadrado");
		n = Convert.ToInt32(Console.ReadLine());
		
		while (n != 0){
			r = n * n;
			
			Console.WriteLine("El cuadrado de " + n + " es " + r + ".");
			Console.WriteLine("Introduzca otro numero");
			n = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("El cuadrado de 0 es 0");
	}
}
