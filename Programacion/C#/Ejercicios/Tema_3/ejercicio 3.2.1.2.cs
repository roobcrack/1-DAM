//¿Cuál sería el resultado de las siguientes operaciones, usando números reales? a=5; a/=2; a+=1; a*=3; --a;
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		
		float a=5;
		Console.WriteLine("a=5: {0}",a);
		
		a/=2;
		Console.WriteLine("a/=2: {0}",a);
		
		a+=1;
		Console.WriteLine("a+=1: {0}",a);
		
		a*=3;
		Console.WriteLine("a*=3: {0}",a);
		
		--a;
		Console.WriteLine("--a: {0}",a);
	}
}
