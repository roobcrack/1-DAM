//Crea un programa que use tres variables x,y,z. Sus valores iniciales serán 
//15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el 
//formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el 
//resultado obtenido por el programa
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int x=15, y=-10, z=214;
		
		x += 12;
		Console.WriteLine("15 incrementado 12 veces es = {0}",x);
		
		y += 12;
		Console.WriteLine("-10 incrementado 12 veces es = {0}",y);
		
		z += 12;
		Console.WriteLine("214 incrementado 12 veces es = {0}",z);
	}
}
