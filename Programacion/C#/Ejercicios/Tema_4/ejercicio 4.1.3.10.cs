/*Un programa que reserve espacio para dos vectores de 3 componentes, 
pida al usuario sus valores y calcule la suma de ambos vectores (su primera 
componente será x1+y1, la segunda será x2+y2 y así sucesivamente).
using System;*/
class ej{
	static void Main(){
		int [][] opt = new int [3][];
		opt[0] = new int [3];//A
		opt[1] = new int [3];//B
		opt[2] = new int [3];//suma
		string [] vector = {"A", "B"};
		string [] pos = {"x", "y", "z"};
		
		for(int i=0;i<=1;i++){
			Console.WriteLine("Introduzca 3 valores para el vector {0}.",vector[i]);
			for(int j=0;j<=2;j++){
				try{
					Console.Write("{0}{1}: ",pos[j],i+1);
					opt[i][j] = Convert.ToInt32(Console.ReadLine());
					opt[2][j] = opt[2][j] + opt[i][j];
				}catch(Exception e){Console.WriteLine(e.Message+"\n"); j--;}
			}
		}
		Console.WriteLine("La suma de ambos vectores es: ");
		for(int i=0;i<=2;i++){
			Console.Write("{0}{1}= {2}  ",pos[i],i+1,opt[2][i]);
		}
	}
}

