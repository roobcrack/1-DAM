//Un programa que reserve espacio para dos vectores de 3 componentes, 
//pida al usuario sus valores y calcule la suma de ambos vectores (su primera 
//componente será x1+y1, la segunda será x2+y2 y así sucesivamente).
using System;
class ej{
	static void Main(){
		int [] A = new int [3];
		int [] B = new int [3];
		string [] pos = {"x", "y", "z"};
		int i, suma;
		
		Console.WriteLine("Introduzca 3 valores para el vector A.");
		for(i=0;i<=2;i++){
			Console.Write("{0}1: ",pos[i]);
			A[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Introduzca 3 valores para el vector B.");
		for(i=0;i<=2;i++){
			Console.Write("{0}2: ",pos[i]);
			B[i] = Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine();
		Console.WriteLine("La suma de ambos vectores es: ");
		for(i=0;i<=2;i++){
			suma = A[i] + B[i];
			Console.Write("{0}{1}= {2}  ",pos[i],i+1,suma);
		}
	}
}
