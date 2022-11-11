// Crea un programa que use el operador condicional para dar a una variable 
//llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el 
//usuario son iguales, o "false" si son distintos
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		bool iguales;
		string a,b;
		
		Console.Write("Introduzca un valor: ");
		a = Console.ReadLine();
		Console.Write("Introduzca otro valor: ");
		b = Console.ReadLine();
		
		iguales = (a==b);
		
		if (iguales==true){
			Console.WriteLine("Ambos valores son iguales.");
		}else{
			Console.WriteLine("Ambos valores son distintos.");
		}
	}
}
