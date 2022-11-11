// Crea un programa escriba 4 veces los números del 1 al 5, en una misma línea, usando "for": 12345123451234512345.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n, b;
		
		for (n=1;n<=4;n++)
			for (b=1;b<=5;b++)
			Console.Write(b);
	}
}
