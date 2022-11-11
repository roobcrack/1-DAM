/*) Crea una función llamada "BorrarPantalla", que borre la pantalla dibujando 
25 líneas en blanco. Crea también un "Main" que permita probarla.*/
using System;
class ej{
	static void Main(){
		
		Console.WriteLine("Press enter to remove all content");
		Console.ReadLine();
		
		RemoveScreen();
	}
	
	static void RemoveScreen(){
		for(int i=0;i<=25;i++){
			Console.WriteLine();
		}
	}
}
