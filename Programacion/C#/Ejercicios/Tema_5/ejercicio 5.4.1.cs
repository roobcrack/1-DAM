/*Crea una función "Cubo" que calcule el cubo de un número real (float) que 
se indique como parámetro. El resultado deberá ser otro número real. Prueba esta 
función para calcular el cubo de 3.2 y el de 5*/
using System;
class Ejercicio_5_4_1{
	static void Main(){
		double number;
		
		Console.Write("Enter a number (you can enter floats).\nInsert: ");
		number = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("\n{0} Pow 3 is {1}.",number,Pow(number));
	}
	
	static double Pow(double number){
		double res = number*number*number;
		return res;
	}
}
