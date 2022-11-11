/*) Crea una función llamada "Signo", que reciba un número real, y devuelva un 
número entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es 
cero.*/
using System;
class Ejercicio_5_4_3{
	static void Main(){
		int number;
		
		Console.WriteLine("Entera number, it can be positive, negative or zero.");
		Console.Write("If the return is -1 number is negative, if it is 0 number is zero and if it is 1 number is positive.\nInsert: ");
		number = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("\nOutput: {0}",Sign(number));
		
	}
	
	static int Sign(int number){
		if(number<0){
			number = -1;
		}else if(number>0){
			number = 1;
		}else{
			number = 0;
		}
		return number;
	}
}
