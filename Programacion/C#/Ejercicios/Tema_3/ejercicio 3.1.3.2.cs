//¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; 
//b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para 
//ver si habías hallado la solución correcta.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int a = 5;
		Console.WriteLine("a = 5: {0}",a);
		
		int b = ++a;
		Console.WriteLine("b = ++a: {0}",b);
		
		int c = a++;
		Console.WriteLine("c = a++: {0}",c);
		
		b = b * 5;
		Console.WriteLine("b = b * 5: {0}",b);
		
		a = a * 2;
		Console.WriteLine("a = a * 2: {0}",a);
	}
}
