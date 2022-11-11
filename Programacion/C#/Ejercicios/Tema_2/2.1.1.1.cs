using System;
class ej{
	static void Main(){
		int n;
		
		Console.WriteLine("Introduzca un numero");
		n = Convert.ToInt32(Console.ReadLine());
		
		if(n == 0){
			Console.WriteLine("El numero es 0");
		}
		else if(n % 2 == 0){
			Console.WriteLine("El numero es par");
		}
		else{
			Console.WriteLine("El numero es impar");
		}
	}
}
