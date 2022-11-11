//(3.2.7.2) Diseña un programa que calcule cualquier raíz (de cualquier orden) de un 
//número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz 
//(por ejemplo, 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que 
//elevar 2 a 1/3.
// Ruben Martinez Martinez

using System;
class ej{
	static void Main(){
		double num, raiz;
		
		Console.Write("Introduzca un numero para calcular su raiz: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Introduzca su raiz: ");
		raiz = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("");
		Console.WriteLine("La raiz elevada a {0} de {1} es = " + Math.Pow(num, 1/raiz), num, raiz);
	}
}
