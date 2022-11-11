//Calcula el área de un círculo, dado su radio, que será un número entero
//(área = pi * radio al cuadrado). Usa datos de doble precisión
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double pi=3.141592653589793238, radio = 6, area;
		
		radio *= radio;
		area = pi * radio;
		Console.WriteLine("Una circunferencia de radio 6cm tiene un area de {0}cm",area);
	}
}
