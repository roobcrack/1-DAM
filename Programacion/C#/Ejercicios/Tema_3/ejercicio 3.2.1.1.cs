// Crea un programa que muestre el resultado de dividir 3 entre 4, primero
//usando números enteros y luego usando números de coma flotante.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int res;
		float f1= 3, f2= 4, res2;
		
		res = 3 / 4;
		Console.WriteLine("El resultado de dividir 3/4 con int = {0}",res);
		
		res2 = f1 / f2;
		Console.WriteLine("El resultado de dividir 3/4 con float = {0}",res2);
	}
}
