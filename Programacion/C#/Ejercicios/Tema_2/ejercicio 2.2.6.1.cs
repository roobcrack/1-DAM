//Crea un programa que escriba 4 líneas de texto, cada una de las cuales estará formada por los números del 1 al 5.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int fila, columna;
		int alto = 5;
		int ancho = 10;

		for (fila=1; fila <= alto; fila++){
			for (columna=1; columna <= ancho; columna++)
			Console.Write("12345");
			Console.WriteLine();
		}
	}
}
