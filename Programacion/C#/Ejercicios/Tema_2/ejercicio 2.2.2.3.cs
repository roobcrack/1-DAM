//Crea un programa que escriba en pantalla los números pares del 26 al 10 (descendiendo), usando "do..while".
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n = 26;
		
		do{
			Console.WriteLine(n);
			n = n - 2;
		}
		while (n >= 10);
	}
}
