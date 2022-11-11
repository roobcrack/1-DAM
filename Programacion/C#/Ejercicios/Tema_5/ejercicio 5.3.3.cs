/*Crea una función "DibujarRectanguloHueco" que dibuje en pantalla un 
rectángulo hueco del ancho y alto que se indiquen como parámetros, formado por 
una letra que también se indique como parámetro. Completa el programa con un 
Main que pida esos datos al usuario y dibuje el rectángulo.*/
using System;
class Ejercicio_5_3_3{
	static void Main(){
		int squareLong, squareTall;
		char squareChar;
		
		Console.Write("Enter how long you want the square to be.\nInsert: ");
		squareLong = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter how tall you want the square to be.\nInsert: ");
		squareTall = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter what character you want the square to be formed.\nInsert: ");
		squareChar = Convert.ToChar(Console.ReadLine());
		
		DrawSquare(squareLong, squareTall, squareChar);
	}
	
	static void DrawSquare(int squareLong, int squareTall, char squareChar){
		for(int i=0;i<squareTall;i++){
			for(int j=0;j<squareLong;j++){
				
				if((i==0)||(i==squareTall-1)){ //For the 1st and last line
					Console.Write(squareChar);
				}else if(i<squareTall-1){      //For the rest of lines
					if((j==0)||(j==squareLong-1)){Console.Write(squareChar);}else{Console.Write(" ");}
				}
			}
			Console.WriteLine();
		}
	}
}
