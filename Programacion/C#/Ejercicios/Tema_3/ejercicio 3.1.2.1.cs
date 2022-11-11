//Pregunta al usuario su edad, que se guardará en un "byte". A 
//continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No 
//aparentas 20 años").
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		byte edad;
		
		Console.WriteLine("Introduzca su edad");
		edad = Convert.ToByte(Console.ReadLine());
		
		Console.WriteLine("No aparenta los {0}", edad);
	}
}
