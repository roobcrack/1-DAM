//Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2+ Bx + C. 
//Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double a, b, c, res;
		
		Console.WriteLine("Para calcular la ecuacion y = Ax2+Bx+C");
		Console.WriteLine("Introduzca un valor para A, B y C en su respectivo orden");
		
		a = Convert.ToDouble(Console.ReadLine());
		b = Convert.ToDouble(Console.ReadLine());
		c = Convert.ToDouble(Console.ReadLine());
		
		double op = (((b*b)-4)(*a*c))/(2*a);
		res = -b+Math.Sqrt(op);
	}
}
