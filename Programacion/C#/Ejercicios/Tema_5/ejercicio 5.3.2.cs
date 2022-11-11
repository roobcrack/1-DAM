/*Crea una función "DibujarRectangulo" que dibuje en pantalla un rectángulo 
del ancho y alto que se indiquen como parámetros, en ese orden. Incluye un Main 
para probarla.*/
using System;
class Ejercicio_5_3_2{	
	static void Main(){
		int squareLong=0, squareTall=0;
		bool done=false;
		
		while(!done){
			try{
				Console.Write("Enter how long you want the square to be.\nInsert: ");
				squareLong = Convert.ToInt32(Console.ReadLine());
				if(squareLong==0){
					Console.WriteLine("ERROR.Long can't be 0.\n");
				}else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
		
		done=false;
		Console.WriteLine();
		
		while(!done){
			try{
				Console.Write("Enter how tall you want the square to be.\nInsert: ");
				squareTall = Convert.ToInt32(Console.ReadLine());
				if(squareTall==0){
					Console.WriteLine("ERROR.Tall can't be 0.\n");
				}else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
		
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
