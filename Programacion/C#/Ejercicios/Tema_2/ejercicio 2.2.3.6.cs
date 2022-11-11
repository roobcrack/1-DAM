//Crea un programa que muestre los números del 15 al 5, descendiendo 
//(pista: en cada pasada habrá que descontar 1, por ejemplo haciendo i=i-1, que se 
//puede abreviar i--).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int i=15;
		
		while(i >= 5){
			for (i=15;i>=5;i--)
			Console.Write(i + " ");
		}
	}
}
