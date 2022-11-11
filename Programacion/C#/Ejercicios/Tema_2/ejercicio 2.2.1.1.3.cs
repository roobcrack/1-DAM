//Crea un programa que pida de forma repetitiva pares de números al 
//usuario. Tras introducir cada par de números, responderá si el primero es múltiplo 
//del segundo. Se repetirá mientras los dos números sean distintos de cero 
//(terminará cuando uno de ellos sea cero).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n1, n2;
		
		Console.WriteLine("Introduzca un numero que no sea 0");
		n1 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduzca otro numero que no sea 0");
		n2 = Convert.ToInt32(Console.ReadLine());
		
		while ((n1 != 0) || (n2 != 0)){
			if (n2 % n1 == 0){
				Console.WriteLine("El primer numero es multiplo del segundo");
			}
			else {
				Console.WriteLine("El primer numero no es multiplo del segundo");
			}
			Console.WriteLine("Vamos a volver a hacerlo");
			
			Console.WriteLine("Introduzca un numero que no sea 0");
			n1 = Convert.ToInt32(Console.ReadLine());
		
			Console.WriteLine("Introduzca otro numero que no sea 0");
			n2 = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Ha introducido 0");
	}
}
