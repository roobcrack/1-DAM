// Crea un programa que pida al usuario una cantidad de kilómetros y 
//muestre su equivalencia en millas. El valor de conversión debe estar en una 
//variable definida con "var".
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double km;
		const double millas= 1.609;
		
		Console.Write("Introduzca un valor en km: ");
		km = Convert.ToDouble(Console.ReadLine());
		
		var res = (km * 1000) / millas;
		
		Console.WriteLine("{0} km a millas son: {1}",km,res.ToString("N3"));
	}
}
