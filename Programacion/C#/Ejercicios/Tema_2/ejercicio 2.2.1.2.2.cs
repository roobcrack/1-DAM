//Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "while".
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n = 26;
		
		while (n >= 10){
			Console.WriteLine(n);
			n = n - 2;
		}
	}
}
