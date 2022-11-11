// Crea un programa que permita convertir de millas a metros. El valor 
//necesario para la conversión debe estar almacenado en una constante. 1 milla = 1.609 metros
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		const double metros=1.609;
		double res, millas;
		
		Console.Write("Introduzca un valor en millas: ");
		millas = Convert.ToDouble(Console.ReadLine());
		
		res = millas * metros;
		Console.WriteLine("{0} millas en metros son: {1}.", millas, res);
	}
}
