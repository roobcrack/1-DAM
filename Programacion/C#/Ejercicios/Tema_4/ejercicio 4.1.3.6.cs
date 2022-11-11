// Un programa que pida 10 nombres y los memorice (pista: esta vez se 
//trata de un array de "string"). Después deberá pedir que se teclee un nombre y 
//dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir 
//otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se 
//teclee "fin". En el siguiente apartado verás detalles de cómo hacer ese tipo de búsquedas.
using System;
class ej{
	static void Main(){
		string [] nombre = new string[10];
		string nom="a";
		int i;
		
		Console.WriteLine("Introduzca 10 nombres");
		for(i=0;i<=9;i++){
			Console.Write("Nombre {0}: ",i+1);
			nombre[i] = Console.ReadLine();
		}
		
		while(nom!="fin"){
			Console.WriteLine();
			Console.WriteLine("Ahora introduzca un nombre para ver si coincide con alguno de los introducidos, para salir introduzca \"fin\".");
			Console.WriteLine("Si el nombre no esta en la lista, seguirá preguntando nombres");
			Console.Write("Inserte: ");
			nom = Console.ReadLine();
			
			for(i=0;i<=9;i++){
				if(nom==nombre[i]){
					Console.WriteLine();
					Console.WriteLine("{0} si esta en la lista",nombre[i]);
				}
			}
		}	
	}
}
