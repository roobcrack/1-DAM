//Crea un programa que pida al usuario su nombre, y le diga "Hola" si se 
//llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		string frase;
		
		Console.Write("Introduzca su nombre: ");
		frase = Console.ReadLine();
		
		if(frase == "Juan"){
			Console.WriteLine("Hola Juan");
		}else{
			Console.WriteLine("No te conozco");
		}
	}
}
