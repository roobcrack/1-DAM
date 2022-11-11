/*Crea una función "EscribirRepetido", que reciba un carácter y un número, y 
escriba ese carácter tantas veces como indique ese número (todas ellas en la 
misma línea).*/
using System;
class Ejercicio_5_3_4{
	static void Main(){
		int timesChar;
		char charEnter;
		
		Console.Write("Enter what character you want to repeat.\nInsert: ");
		charEnter = Convert.ToChar(Console.ReadLine());
		Console.Write("Enter how many times you want to repeat.\nInsert: ");
		timesChar = Convert.ToInt32(Console.ReadLine());
		
		RepeatChar(timesChar, charEnter);
	}
	
	static void RepeatChar(int timesChar, char charEnter){
		for(int i=0;i<timesChar;i++){
			Console.Write(charEnter);
		}
	}
}
