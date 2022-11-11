// Crea un programa que muestre los primeros ocho números pares: 2 4 6 8 
//10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar 
//el doble del valor que hace de contador).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int i=0;
		
		while (i<=16){
			for(i=0;i<=16;i=i+2)
			Console.Write(i + " ");
		}
	}
}
