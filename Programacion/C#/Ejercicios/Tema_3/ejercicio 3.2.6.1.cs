// Crea un programa que pida números (en base 10) al usuario y muestre su 
//equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el 
//usuario introduzca el número 0
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int num;
		
		Console.Write("Introduzca un numero: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		while (num != 0){
		Console.WriteLine("El numero en base binaria es: {0}",Convert.ToString(num, 2));
		Console.WriteLine("El numero en base hexadecimal es: {0}", Convert.ToString(num, 16));
		
		Console.WriteLine("");
		Console.Write("Introduzca un numero: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		}
	}
}
