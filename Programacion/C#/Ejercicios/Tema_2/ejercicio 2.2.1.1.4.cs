// Crea una versión mejorada del programa anterior, que, tras introducir 
//cada par de números, responderá si el primero es múltiplo del segundo, o el 
//segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro.
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
			else if (n1 % n2 == 0){
				Console.WriteLine("El segundo numero es multiplo del primero");
			}
			else {
				Console.WriteLine("Ninguno de ellos es multiplo del otro");
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
