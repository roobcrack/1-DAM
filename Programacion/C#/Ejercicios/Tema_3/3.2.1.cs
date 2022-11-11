//Ruben Martinez Martinez
using System;
class Ejercicio_3_2_1{
	static void Main(){
		int ejercicio, i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca que ejercicio quiere probar.");
				for(i=0;i<2;i++){
					Console.WriteLine("{0}.Ejercicio 4.1.1.{0}",i+1);
				}
				Console.WriteLine("0.Para salir del programa");
				Console.Write("Inserte: ");
				ejercicio = Convert.ToInt32(Console.ReadLine());
				
				if(ejercicio==0){
					Console.WriteLine();
					Console.WriteLine("Ejercicio finalizado.");
					done=true;
				}
		
				switch(ejercicio){
					case 1: Console.WriteLine();
							Ejercicio_3_2_1_1(); break;
					case 2: Console.WriteLine(); 
							Ejercicio_3_2_1_2(); break;	
					default: if(ejercicio!=0){
								Console.WriteLine("ERROR.Introduzca un valor valido por favor");
								Console.WriteLine(); 
							 } break;
							
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}

//¿Cuál sería el resultado de las siguientes operaciones, usando números reales? a=5; a/=2; a+=1; a*=3; --a;
	static void Ejercicio_3_2_1_1(){
		
		float a=5;
		Console.WriteLine("a=5: {0}",a);
		
		a/=2;
		Console.WriteLine("a/=2: {0}",a);
		
		a+=1;
		Console.WriteLine("a+=1: {0}",a);
		
		a*=3;
		Console.WriteLine("a*=3: {0}",a);
		
		--a;
		Console.WriteLine("--a: {0}",a);
		Console.WriteLine();
	}

// Crea un programa que muestre el resultado de dividir 3 entre 4, primero
//usando números enteros y luego usando números de coma flotante.
	static void Ejercicio_3_2_1_2(){
		int res;
		float f1= 3, f2= 4, res2;
		
		res = 3 / 4;
		Console.WriteLine("El resultado de dividir 3/4 con int = {0}",res);
		
		res2 = f1 / f2;
		Console.WriteLine("El resultado de dividir 3/4 con float = {0}",res2);
		Console.WriteLine();
	}
}
