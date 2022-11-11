// Crea un programa que use tres variables x,y,z. Las tres serán números 
//reales, y nos bastará con datos de simple precisión. Se deberá pedir al usuario los 
//valores para las tres variables y mostrar en pantalla el valor de x2
//+ y - z (con exactamente dos cifras decimales).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double x, y, z, res;
		
		Console.WriteLine("Introduzca los valores de x, y, z respectivamente");
		Console.Write("x: ");
		x = Convert.ToDouble(Console.ReadLine());
		Console.Write("y: ");
		y = Convert.ToDouble(Console.ReadLine());
		Console.Write("z: ");
		z = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("");
		
		res = (x*x)+y-z;
		
		Console.WriteLine("x^2 + y - z = {0}",res.ToString("0.00"));
	}
}
