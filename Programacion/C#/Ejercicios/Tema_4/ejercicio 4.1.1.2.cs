//) Un programa que pida al usuario 5 números reales (pista: necesitarás un 
//array de "float") y luego los muestre en el orden contrario al que se introdujeron.
using System;
class ej{
	static void Main(){
		double [] numero = new double[5];
		int i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 5 numeros");
				for(i=0;i<=4;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToDouble(Console.ReadLine());
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor numerico valido.");
				Console.WriteLine();
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Usted ha introducido estos numeros pero en sentido inverso");
		
		for(i=4;i>=0;i--){
			Console.WriteLine("Numero {0}: {1}",i+1,numero[i]);
		}
	}
}
