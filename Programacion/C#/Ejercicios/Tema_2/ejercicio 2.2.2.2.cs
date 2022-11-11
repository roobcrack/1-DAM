//Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while".
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n = 1;
		
		do{
			Console.WriteLine(n);
			n = n + 1;
		}
		while (n <= 10);
	}
}
