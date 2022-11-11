//Un programa que reserve espacio para un vector de 3 componentes, pida 
//al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su 
//módulo (la raíz cuadrada de la suma de sus componentes al cuadrado; por 
//ejemplo, para [2, -5, 7] el resultado sería la raíz cuadrada de 78, aproximadamente 8,83).
using System;
class ej{
	static void Main(){
		int [] numero = new int[3];
		int i;
		double suma=0;
		
		Console.WriteLine("Introduzca 3 valores para 3 vectores respectivamente.");
		
		for(i=0;i<=2;i++){
			Console.Write("Vector {0}: ",i+1);
			numero [i] = Convert.ToInt32(Console.ReadLine());
			suma = suma + Math.Pow(numero[i], 2);
		}
		suma = Math.Sqrt(suma);
		
		Console.WriteLine("Su modulo es: {0}",suma);
	}
}
