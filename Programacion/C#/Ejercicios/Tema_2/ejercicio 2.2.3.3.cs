//Crea un programa que muestre los números del 100 al 200 (ambos incluidos) que sean divisibles entre 7 y a la vez entre 3.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int i=100;
		
		while (i <= 200){
			for (i=100;i<=200;i++)
			if ((i % 3 == 0) || (i % 7 == 0)){
				Console.Write(i + " ");
			}
		}
	}
}
