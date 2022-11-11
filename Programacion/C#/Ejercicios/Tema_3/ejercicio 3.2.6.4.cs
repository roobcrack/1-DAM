//Crea un programa que pida números binarios al usuario y muestre su 
//equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el 
//usuario introduzca la palabra "fin".
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		string num;
		int num2;
		
		Console.Write("Introduzca un numero binario: ");
		num = Convert.ToString(Console.ReadLine());
		
		while (num != "fin"){
		Console.WriteLine("El numero en base decimal es: {0}",Convert.ToInt32(num, 2));
		num2 = Convert.ToInt32(num, 2);
		Console.WriteLine("El numero en base hexadecimal es: {0}", Convert.ToString(num2, 16));
		Console.WriteLine("Introduzca \"fin\" para finalizar");
		
		Console.WriteLine("");
		Console.Write("Introduzca un numero: ");
		num = Convert.ToString(Console.ReadLine());
		
		}
	}
}
