/* Un programa que pida al usuario dos bloques de 10 números enteros 
(usando un array de dos dimensiones). Después deberá mostrar el mayor dato 
que se ha introducido en cada uno de ellos.*/
using System;
class ej{
	static void Main(){
		int [,] numbers = new int[2,5];
		int maxNumber=0;
		         
		Console.WriteLine("Enter 10 numbers: ");
		for(int i=0;i<2;i++){
			for(int j=0;j<5;j++){
				try{
					Console.Write("Insert {0}.{1}: ",i+1,j+1);
					numbers [i,j] = Convert.ToInt32(Console.ReadLine());
				}catch(Exception e){Console.WriteLine(e.Message+"\n");j--;}
				if(numbers [i,j]>maxNumber){
					maxNumber=numbers [i,j];
				}
			}
		}
		Console.WriteLine("Max number is: {0}",maxNumber);
	}
}
