// Crea un programa que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), 
//usando la expresión d = raíz [(x1-x2)2+ (y1-y2)2]
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double x1, x2, y1, y2, d;
		
		Console.WriteLine("Introduzca 2 valores para la x: ");
		Console.Write("x1: ");
		x1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("x2: ");
		x2 = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Introduzca 2 valores para la y: ");
		Console.Write("y1: ");
		y1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("y2: ");
		y2 = Convert.ToDouble(Console.ReadLine());
		
		d = Math.Sqrt((Math.Pow((x1 - x2), 2)) + (Math.Pow((y1 - y2), 2)));
		
		Console.WriteLine("");
		Console.WriteLine("La distancia entre dichos puntos es: {0}",d);
	}
}
