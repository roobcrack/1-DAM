// Crea un programa que pida al usuario un nombre y una contraseña. La 
//contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se 
//avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como 
//sea necesario hasta que coincidan.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		string name, password, password2;
		
		Console.Write("Introduzca un nombre: ");
		name = Console.ReadLine();
		
		Console.Write("Introduzca la contraseña: ");
		password = Console.ReadLine();
		
		Console.Write("Vuelva a introducir la contraseña: ");
		password2 = Console.ReadLine();
		
		while(password != password2){
			Console.WriteLine();
			Console.WriteLine("Las contraseñas no coinciden, vuelva a intentarlo");
			
			Console.Write("Introduzca la contraseña: ");
			password = Console.ReadLine();
		
			Console.Write("Vuelva a introducir la contraseña: ");
			password2 = Console.ReadLine();
		}
		Console.WriteLine("Registro completado");
		
	}
}
