//Pide al usuario dos números enteros largos ("long") y muestra su suma, su resta y su producto.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		long n1, n2, res;
		
		Console.WriteLine("Introduzca un numero");
		n1 = Convert.ToInt64(Console.ReadLine());
		
		Console.WriteLine("Introduzca otro numero");
		n2 = Convert.ToInt64(Console.ReadLine());
		
		res = n1 + n2;
		Console.WriteLine("La suma de ambos numeros es {0}",res);
		
		res = n1 - n2;
		Console.WriteLine("La resta de ambos numeros es {0}",res);
		
		res = n1 * n2;
		Console.WriteLine("El producto de ambos numeros es {0}",res);
	}
}
