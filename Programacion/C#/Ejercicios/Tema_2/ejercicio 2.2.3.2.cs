//Crea un programa que escriba en pantalla los números del 1 al 50 que 
//sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto 
//de la división entre 3 resulta 0).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int i=1;
		
		while (i<50){
			for (i=1;i<=50;i++)
			if (i % 3 == 0){
				Console.Write(i + " ");
			}
		}
		
		
	}
}
