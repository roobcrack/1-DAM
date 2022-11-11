//Calcula el producto de 1.000.000 por 1.000.000, usando una variable 
//llamada "producto", de tipo "long". Prueba también a calcularlo usando una variable de tipo "int".
// Ruben Martinez Martinez

using System;
class Ejercicio_3_1_{
	static void Main(){
		uint num = 1000000;
		ulong producto;
		
		producto = num * num;
		Console.WriteLine(producto);
	}
}
