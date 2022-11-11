//Ruben Martinez Martinez
using System;
class ej4_1_1{
	static void Main(){
		int ejercicio=0;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca que ejercicio quiere probar, introduzca 0 para salir del programa.");
				Console.WriteLine("1.Ejercicio 4.1.1.1\n" + "2.Ejercicio4.1.1.2");
				Console.Write("Inserte: ");
				ejercicio = Convert.ToInt32(Console.ReadLine());
				
				if(ejercicio==0){
					Console.WriteLine();
					Console.WriteLine("Ejercicio finalizado");
					done=true;
				}
		
				switch(ejercicio){
					case 1: Console.WriteLine();
							ej4_1_1_1(); break;
					case 2: Console.WriteLine(); 
							ej4_1_1_2(); break;	
					default: if(ejercicio!=0){
								Console.WriteLine("ERROR.Introduzca un valor valido por favor");
								Console.WriteLine(); 
							 } break;
							
				}
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor valido por favor");
				Console.WriteLine();
			}
		}
	}
	
//) Un programa que pida al usuario 4 números, los memorice (utilizando un 
//array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
	static void ej4_1_1_1(){
		int [] numero = new int[5];
		int i, suma=0;
		bool done=false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 4 numeros.");
				for(i=0;i<=3;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToInt32(Console.ReadLine());
			
					suma = suma + numero[i];
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un numero natural.");
				Console.WriteLine();
			}
		}
		
		suma = suma / 4;
		Console.WriteLine("La media aritmetica de los 4 numeros es: {0}",suma);
		Console.WriteLine("----------");
		Console.WriteLine();
	}
	
//) Un programa que pida al usuario 5 números reales (pista: necesitarás un 
//array de "float") y luego los muestre en el orden contrario al que se introdujeron.
		static void ej4_1_1_2(){
		double [] numero = new double[5];
		int i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 5 numeros");
				for(i=0;i<=4;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToDouble(Console.ReadLine());
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor numerico valido.");
				Console.WriteLine();
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Usted ha introducido estos numeros pero en sentido inverso");
		
		for(i=4;i>=0;i--){
			Console.WriteLine("Numero {0}: {1}",i+1,numero[i]);
		}
		Console.WriteLine("----------");
		Console.WriteLine();
	}	
}
