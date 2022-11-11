//Pide al usuario dos números de dos cifras ("byte"), calcula su 
//multiplicación, que se deberá guardar en un "int", y muestra el resultado en pantalla
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		byte n1, n2;
		
		Console.WriteLine("Introduzca un numero");
		n1 = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("Introduzca otro numero");
		n2 = Convert.ToByte(Console.ReadLine());
		
		int res = n1 * n2;
		
		Console.WriteLine("El el producto de ambos numeros es: {0}", res);
	}
}
