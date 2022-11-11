//Un programa que prepare espacio para guardar un máximo de 100 
//nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se 
//pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres 
//y se mostrará en pantalla la lista de los nombres que se han introducido.
using System;
class ej{
	static void Main(){
		string [] nombre = new string[100];
		string nom;
		
		do{
		Console.WriteLine("Introduzca un nombre, esta accion se repetira hasta que pulse enter.");
		Console.Write("Inserte: ");
		nom = Console.ReadLine();
		}while(nom!=null);
	}
}
