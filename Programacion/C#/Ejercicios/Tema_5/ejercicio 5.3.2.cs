/*Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo 
del ancho y alto que se indiquen como parámetros, en ese orden. Incluye un Main 
para probarla.*/
using System;
class Ejercicio_5_3_2{	
	static void Main(){
		int squareLong, squareTall;
		bool done=false;
		
		Console.Write("Enter how long you want the square to be.\nInsert: ");
		squareLong = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter how tall you want the square to be.\nInsert: ");
		squareTall = Convert.ToInt32(Console.ReadLine());
		
		DrawSquare(squareLong, squareTall);
	}
	
	static void DrawSquare(int squareLong, int squareTall){
		for(int i=0;i<squareTall;i++){
			for(int j=0;j<squareLong;j++){
				Console.Write("*");
			}
			Console.WriteLine();
		}
	}
}
