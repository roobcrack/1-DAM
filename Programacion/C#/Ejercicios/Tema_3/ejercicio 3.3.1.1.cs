//Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		char letra;
		
		Console.WriteLine("Introduzca una letra");
		letra = Convert.ToChar(Console.ReadLine());
		
		switch(letra){
			case 'a': Console.WriteLine("La letra es una vocal."); break;
			case 'e': Console.WriteLine("La letra es una vocal."); break;
			case 'i': Console.WriteLine("La letra es una vocal."); break;
			case 'o': Console.WriteLine("La letra es una vocal."); break;
			case 'u': Console.WriteLine("La letra es una vocal."); break;
		default: Console.WriteLine("La letra es una consonante."); break;
		}
		
	}
}
