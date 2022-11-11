//Ruben Martinez Martinez
using System;
class ej4_1_3{
	static void Main(){
		int ejercicio=0;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca que ejercicio quiere probar, introduzca 0 para salir del programa.");
				Console.WriteLine("1.Ejercicio 4.1.3.1\n" + "2.Ejercicio 4.1.3.2\n" + "3.Ejercicio 4.1.3.3");
				Console.Write("Inserte: ");
				ejercicio = Convert.ToInt32(Console.ReadLine());
				
				if(ejercicio==0){
					Console.WriteLine();
					Console.WriteLine("Ejercicio finalizado");
					done=true;
				}
		
				switch(ejercicio){
					case 1: Console.WriteLine();
							ej4_1_3_1(); break;
					case 2: Console.WriteLine(); 
							ej4_1_3_2(); break;
					case 3: Console.WriteLine(); 
							ej4_1_3_3(); break;	
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

//) Crea un programa que pida al usuario 6 números enteros cortos y luego 
//los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para mostrarlos).
	static void ej4_1_3_1(){
		int [] numero = new int[6];
		int i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 6 numeros");
				for(i=0;i<=5;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToInt32(Console.ReadLine());
				}
				done = true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un numero natural.");
				Console.WriteLine();
			}
		}
		
		Console.WriteLine();
		Console.WriteLine("Usted ha introducido estos numeros pero en sentido inverso");
		
		for(i=5;i>=0;i--){
			Console.WriteLine("Numero {0}: {1}",i+1,numero[i]);
		}
		Console.WriteLine("----------");
		Console.WriteLine();
	}
	
// Crea un programa que pregunte al usuario cuántos números enteros va a 
//introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y 
//finalmente calcule y muestre la media de esos números.
	static void ej4_1_3_2(){
		int i, suma=0;
		bool done = false;
		int n=0;

		while(!done){
			try{
				Console.WriteLine("¿Cuantos numeros quiere introducir para calcular su media aritmetica?");
				Console.Write("Inserte: ");
				n = Convert.ToInt32(Console.ReadLine());
				if(n==0){
					Console.WriteLine("ERROR.No puede introducir 0 numeros");
					Console.WriteLine(); 
				}else{
					done = true;
				}
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor valido");
				Console.WriteLine(); 
			}
		}
		done = false;
		int [] numero = new int [n];
		while(!done){
			try{
				Console.WriteLine("Introduzca los valores");
				for(i=0;i<=n-1;i++){
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
		suma = suma / n;
		
		Console.WriteLine("La media aritmetica de los numeros introducidos es: {0}",suma);
		Console.WriteLine("----------");
		Console.WriteLine();
	}
	
//) Un programa que pida al usuario 10 reales de doble precisión, calcule su 
//media y luego muestre los que están por encima de la media..
	static void ej4_1_3_3(){
		double [] numero = new double [10];
		double suma=0;
		int i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca 10 numeros en los que puede incluir decimales");
		
				for(i=0;i<=9;i++){
					Console.Write("Numero {0}: ",i+1);
					numero[i] = Convert.ToDouble(Console.ReadLine());
					suma = suma + numero[i];
				}
				suma = suma / 10;
				Console.WriteLine("La media aritmetica de todos los numeros es: {0}",suma);
				Console.WriteLine();
				Console.WriteLine("Y estos son los numeros introducidos mas altos que la media: ");
		
				for (i=0;i<=9;i++){
					if (numero[i]>suma){
						Console.Write("Numero {0}:({1}) ",i+1,numero[i]);
					}
				}
				done=true;
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor valido.");
				Console.WriteLine();
			
			}
		Console.WriteLine();
		Console.WriteLine("----------");
		Console.WriteLine();
		}
	}
}
