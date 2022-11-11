//Crea un programa que muestre el resultado de dividir 13 entre 6 usando 
//números enteros, luego usando números de coma flotante de simple precisión y 
//luego con números de doble precisión
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int i1=13, i2=6,res;
		res = i1/i2;
		Console.WriteLine("13 / 6 con int = {0}",res);
		
		float f1=13, f2=6, res2;
		res2 = f1/f2;
		Console.WriteLine("13 / 6 con float = {0}",res2);
		
		double d1=13, d2=6, res3;
		res3 = d1/d2;
		Console.WriteLine("13 / 6 con float = {0}",res3);
	}
}
