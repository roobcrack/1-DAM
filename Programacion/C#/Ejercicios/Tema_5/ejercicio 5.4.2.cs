/*Crea una función "Menor" que calcule el menor de dos números enteros 
que recibirá como parámetros. El resultado será otro número entero.*/
using System;
class Ejercicio_5_4_2{
	static void Main(){
		int number_1, number_2;
		
		Console.Write("Enter one number.\nInsert: ");
		number_1 = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter onther number.\nInsert: ");
		number_2 = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nThe lowest number is: {0}.",Lowest(number_1, number_2));
	}
	
	static int Lowest(int number_1, int number_2){
		
		if(number_1<number_2){
			return number_1;
		}else{
			return number_2;
		}
	}
}
