//¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; 
//c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		
		int a=5;
		Console.WriteLine("a = 5: {0}",a);
		
		int b=a+2;
		Console.WriteLine("b = a+2: {0}",b);
		
		b -= 3;
		Console.WriteLine("b -= 3: {0}",b);
		
		int c =- 3;
		Console.WriteLine("c =- 3: {0}",c);
		
		++c;
		Console.WriteLine("c++: {0}",c);
		
		a *= b;
		Console.WriteLine("a *= b: {0}", a);
		
		
	}
}
