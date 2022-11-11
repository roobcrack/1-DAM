//Crea un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10)
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n, i = 0;
		
		Console.WriteLine("Introduzca un numero");
		n = Convert.ToInt32(Console.ReadLine());
		
		while (n > 1){
			n = n / 10;
			i = i + 1;
		}
		Console.WriteLine("El numero tiene " + i + " cifras");
	}
}
