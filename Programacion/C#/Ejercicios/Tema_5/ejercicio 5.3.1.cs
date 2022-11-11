/*Crea una función "DibujarCuadrado" que dibuje en pantalla un cuadrado de 
asteriscos del ancho (y alto) que se indique como parámetro. Completa el 
programa con un Main que permita probarla.*/
using System;
class Ejercicio_5_3_1{
	static void Main(){
		int squareSize=0;
		bool done=false;
		
		while(!done){
			try{
				Console.Write("How big you want the sqare to be?\nInsert: ");
				squareSize = Convert.ToInt32(Console.ReadLine());
				if(squareSize==0){Console.WriteLine("ERROR. 0 not valid number.\n");}
				else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
		
		DrawSquare(squareSize);
	}
	
	static void DrawSquare(int squareSize){
		for(int i=0;i<squareSize;i++){
			for(int j=0;j<squareSize;j++){
				Console.Write("*");
			}
		Console.WriteLine();
		}
	}
}
