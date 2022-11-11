//) Un programa que pida al usuario 10 reales de doble precisión, calcule su 
//media y luego muestre los que están por encima de la media
using System;
class ej{
	static void Main(){
		double [] numero = new double [10];
		int i;
		
		Console.WriteLine("Introduzca 10 numeros en los que puede incluir decimales");
		
		for(i=0;i<=10;i++){
			Console.Write("Numero {0}: ",i+1);
			numero[i] = Convert.ToDouble(Console.ReadLine());
		}
	}
}
