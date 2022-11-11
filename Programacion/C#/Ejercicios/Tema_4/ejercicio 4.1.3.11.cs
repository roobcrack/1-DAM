//Un programa que pida al usuario 4 números enteros y calcule (y 
//muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array, 
//hay que comparar cada uno de los valores que tiene almacenados el array con el 
//que hasta ese momento es el máximo provisional. El valor inicial de este máximo 
//provisional no debería ser cero (porque el resultado sería incorrecto si todos los 
//números son negativos), sino el primer elemento del array. Si no lo consigues, en 
//el próximo apartado tienes más detalles sobre cómo resolver este problema.
using System;
class ej{
	static void Main(){
		int [] numero = new int [4];
		int maximo = numero[0];
		
		Console.WriteLine("Enter 4 numbers: ");
		for(int i=0;i<=3;i++){
			try{
				Console.Write("Numero {0}: ",i+1);
				numero[i] = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");i--;}
		}

		for(int i=0;i<=3;i++){
			if((numero[i]>=maximo) || (numero[i]<=maximo)){
				maximo = numero[i];
			}			
		}
		Console.WriteLine("The highest number is: {0}",maximo);
		
	}
}
