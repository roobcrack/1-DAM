//Calcula el perímetro, área y diagonal de un rectángulo, a partir de su 
//ancho y alto (perímetro = suma de los cuatro lados; área = base x altura; diagonal
//= hipotenusa, usando el teorema de Pitágoras). Muestra todos ellos con una cifra decimal.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double ancho, alto, res;
		
		Console.Write("Introduzca el alto del rectangulo: ");
		alto = Convert.ToDouble(Console.ReadLine());
		Console.Write("Introduzca el ancho del rectangulo: ");
		ancho = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("");
		
		//Calculo del perimetro
		res = (alto * 2) + (ancho * 2);
		Console.WriteLine("El perimetro del rectangulo es {0}",res.ToString("0.0"));
		
		//Calculo del area
		res = alto * ancho;
		Console.WriteLine("El area del rectangulo es {0}",res.ToString("0.0"));
		
		//calculo de la diagonal
		res = Math.Sqrt((Math.Pow(alto, 2)) + (Math.Pow(ancho, 2)));
		Console.WriteLine("La diagonal del rectangulo es {0}",res.ToString("0.0"));
		
	}
}
