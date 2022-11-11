//) Crea un programa que pida al usuario 6 números enteros cortos y luego 
//los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para mostrarlos).
using System;
class ej{
	static void Main(){
		int [] numero = new int[6];
		int i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 6 numeros");
				for(i=0;i<=5;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToInt32(Console.ReadLine());
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un numero natural.");
				Console.WriteLine();
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Usted ha introducido estos numeros pero en sentido inverso");
		
		for(i=5;i>=0;i--){
			Console.WriteLine("Numero {0}: {1}",i+1,numero[i]);
		}
	}
}
