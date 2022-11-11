//Crea un programa que pida al usuario a una distancia (en metros) y el 
//tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), 
//y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas 
//por hora (pista: 1 milla = 1.609 metros).
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double distancia, tiempo_horas, tiempo_minutos, tiempo_segundos, tiempo_total;
		double velocidad, millas = 1.609;
		
		Console.WriteLine("Introduzca una distancia en metros");
		distancia = Convert.ToDouble(Console.ReadLine());
		
		Console.WriteLine("Introduzca un tiempo para recorrer dicha distancia en 3 inputs, horas, minutos y segundos.");
		
		tiempo_horas = Convert.ToDouble(Console.ReadLine());
		tiempo_minutos = Convert.ToDouble(Console.ReadLine());
		tiempo_segundos = Convert.ToDouble(Console.ReadLine());
		
		//tiempo en segundos
		tiempo_total = ((tiempo_horas * 60) * 60) + (tiempo_minutos * 60) + tiempo_segundos;
		//velocidad en m/s
		velocidad= distancia / tiempo_total;
		Console.WriteLine("La velocidad en metros/segundo es = {0}",velocidad);
		
		//tiempo en horas
		tiempo_total = ((tiempo_segundos / 60) / 60) + (tiempo_minutos / 60) + tiempo_horas;
		//distancia en km
		distancia = distancia / 1000;
		//velocidad en km/hora
		velocidad = distancia / tiempo_total;
		Console.WriteLine("La velocidad en kilometros/hora es = {0}",velocidad);
		
		//distancia en millas
		distancia = (distancia * 1000) * millas;
		//velocidad en millas/hora
		velocidad = millas / tiempo_total;
		Console.WriteLine("La velocidad en millas/hora es = {0}",velocidad);
	}
}
