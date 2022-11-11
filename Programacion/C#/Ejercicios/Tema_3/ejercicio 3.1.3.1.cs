//Crea un programa que use tres variables enteras x,y,z. Sus valores 
//iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas 
//variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado 
//obtenido por el programa.

// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		int x=15, y=-10, a, b;
		long z=2147483647, c;
		
		a = x++;
		Console.WriteLine("x vaele {0}", a);
		Console.WriteLine("Si lo incrementamos vale {0}", x);
 
		b = y++;
		Console.WriteLine("b vale {0}", b);
		Console.WriteLine("Si lo incrementamos vale {0}", y);
		
		c = z++;
		Console.WriteLine("z vale {0}",c);
		Console.WriteLine("Si lo incrementamos vale {0}",z);
	}
}
