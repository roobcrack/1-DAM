//Calcula la superficie y el volumen de una esfera, a partir de su radio 
//(superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). Usa
//datos "doble" y muestra los resultados con 5 cifras decimales.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double pi=3.141592653589793238, radio, res;
		
		Console.Write("Introduzca el radio de la esfera: ");
		radio = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("");
		
		//Calcuar la superficie
		res = 4 * pi * Math.Pow(radio, 2);
		Console.WriteLine("La superficie de la esfera es {0}",res.ToString("N5"));
		
		//Calcular el volumen
		res = (4/3) * pi * Math.Pow(radio, 3);
		Console.WriteLine("El volumen de la esfera es {0}",res.ToString("N5"));
	}
}
