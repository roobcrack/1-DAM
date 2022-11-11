//Calcula el volumen de una esfera, dado su radio, que será un número de
//doble precisión (volumen = pi * radio al cubo * 4/3)
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double pi=3.141592653589793238, radio = 6, n1=4, n2=3, volumen;
		
		radio = radio*radio*radio;
		volumen = pi * radio * (n1/n2);
		
		Console.WriteLine("El volumen de una esfera cuyo radio es 6cm es igual a {0}",volumen);
	}
}
