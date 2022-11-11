//) Un programa que pida al usuario 4 números, los memorice (utilizando un 
//array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
//Ruben Martinez Martinez
using System;
class ej{
	static void Main(){
		int [] numero = new int[5];
		int i, suma=0;
		bool done=false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 4 numeros.");
				for(i=0;i<=3;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToInt32(Console.ReadLine());
			
					suma = suma + numero[i];
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un numero natural.");
				Console.WriteLine();
			}
		}
		
		suma = suma / 4;
		Console.WriteLine("La media aritmetica de los 4 numeros es: {0}",suma);

	}
}
