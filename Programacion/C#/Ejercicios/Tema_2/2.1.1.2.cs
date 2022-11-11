using System;
class ej{
	static void Main(){
		int num1, num2;
		Console.WriteLine("Introduzca un primer numero");
		
		num1 = Convert.ToInt32(Console.ReadLine());
			
		Console.WriteLine("Introduzca un segundo numero");
			
		num2 = Convert.ToInt32(Console.ReadLine());
			
		if (num1 < num2){
			Console.WriteLine("El segundo numero es mayor que el primero");
		}
		else if (num1 > num2){
				Console.WriteLine("El primer numero es mayor que el segundo");
		}
		else{
			Console.WriteLine("Ambos numeros son iguales");
		}
	}
}
