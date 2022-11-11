//Crea un programa que pida al usuario dos números enteros y diga "Uno 
//de los números es positivo", "Los dos números son positivos" o bien "Ninguno de 
//los números es positivo", según corresponda.
//Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int n1, n2;
		
		Console.WriteLine("Introduzca un numero");
		
		n1 = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Introduzca otro numero");
		
		n2 = Convert.ToInt32(Console.ReadLine());
		
		if ((n1 % 2 == 0) && (n2 % 2 == 0)){
		
			Console.WriteLine("Ambos numeros son pares");
		}
		else if (((n1 % 2 == 0) && (n2 % 2 != 0)) || ((n1 % 2 != 0) && (n2 % 2 == 0))){
			
			Console.WriteLine("Al menos uno de los numeros es impar");
		}
		else{
			Console.WriteLine("Ningun numero es par");
		}
		
		
	}
}
