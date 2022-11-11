//Crea un programa que pida al usuario un ángulo (en grados) y muestre su 
//seno, coseno y tangente. Recuerda que las funciones trigonométricas esperan que 
//el ángulo se indique en radianes, no en grados. La equivalencia es que 180 grados = PI radianes
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double angulo, anguloradianes;
		
		Console.Write("Introduzca un angulo: ");
		angulo = Convert.ToDouble(Console.ReadLine());
		
		anguloradianes = angulo * Math.PI / 180;
		
		Console.WriteLine("El seno de {0}  es: {1}",angulo,Math.Sin(anguloradianes));
		Console.WriteLine("El coseno de {0}  es: {1}",angulo,Math.Cos(anguloradianes));
		Console.WriteLine("La tangente de {0}  es: {1}",angulo,Math.Tan(anguloradianes));
	}
}
