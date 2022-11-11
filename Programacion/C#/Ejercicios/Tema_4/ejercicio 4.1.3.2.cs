// Crea un programa que pregunte al usuario cuántos números enteros va a 
//introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y 
//finalmente calcule y muestre la media de esos números.
using System;
class ej{
	static void Main(){
		int i, suma=0;
		bool done = false;
		int n=0;
		int [] numero = new int [n];

		while(!done){
			try{
				Console.WriteLine("¿Cuantos numeros quiere introducir para calcular su media aritmetica?");
				Console.Write("Inserte: ");
				n = Convert.ToInt32(Console.ReadLine());
				if(n==0){
					Console.WriteLine("No puede introducir 0 numeros");
				}else{
					done = true;
				}
			}catch{
				Console.WriteLine("Introduzca un valor valido");
			}
		}
		done = false;
		while(!done){
			try{
				Console.WriteLine("Introduzca los valores");
				for(i=0;i<=n-1;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToInt32(Console.ReadLine());
					suma = suma + numero[i];
					done = true;
				}
			}catch{
				Console.WriteLine("ERROR.Introduzca un numero natural.");
				Console.WriteLine();
			}
		}
		suma = suma / n;
		
		Console.WriteLine("La media aritmetica de los numeros introducidos es: {0}",suma);
	}
}
