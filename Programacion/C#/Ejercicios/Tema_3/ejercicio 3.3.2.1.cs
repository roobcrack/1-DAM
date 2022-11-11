//Crea un programa que pida al usuario que teclee cuatro letras y las 
//muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles. Por 
//ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola"
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		char l1,l2,l3,l4;
		
		Console.WriteLine("Teclee 4 letras: ");
		Console.Write("1: ");
		l1=Convert.ToChar(Console.ReadLine());
		Console.Write("2: ");
		l2=Convert.ToChar(Console.ReadLine());
		Console.Write("3: ");
		l3=Convert.ToChar(Console.ReadLine());
		Console.Write("4: ");
		l4=Convert.ToChar(Console.ReadLine());
		
		Console.WriteLine();
		Console.WriteLine("Usted ha escirto \"{0}{1}{2}{3}\", al reves.",l4,l3,l2,l1);
	}
}
