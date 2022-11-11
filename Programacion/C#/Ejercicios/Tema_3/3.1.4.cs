//Ruben Martinez Martinez
using System;
class Ejercicio_3_1_4{
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
							Ejercicio_3_1_4_1(); break;
					case 2: Console.WriteLine(); 
							Ejercicio_3_1_4_2(); break;	
					default: if(ejercicio!=0){
								Console.WriteLine("ERROR.Introduzca un valor valido por favor");
								Console.WriteLine(); 
							 } break;
							
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}

//Crea un programa que use tres variables x,y,z. Sus valores iniciales serán 
//15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el 
//formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el 
//resultado obtenido por el programa
	static void Ejercicio_3_1_4_1(){
		int x=15, y=-10, z=214;
		
		x += 12;
		Console.WriteLine("15 incrementado 12 veces es = {0}",x);
		
		y += 12;
		Console.WriteLine("-10 incrementado 12 veces es = {0}",y);
		
		z += 12;
		Console.WriteLine("214 incrementado 12 veces es = {0}",z);
		Console.WriteLine();
	}

//¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; 
//c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre
	static void Ejercicio_3_1_4_2(){
		
		int a=5;
		Console.WriteLine("a = 5: {0}",a);
		
		int b=a+2;
		Console.WriteLine("b = a+2: {0}",b);
		
		b -= 3;
		Console.WriteLine("b -= 3: {0}",b);
		
		int c =- 3;
		Console.WriteLine("c =- 3: {0}",c);
		
		++c;
		Console.WriteLine("c++: {0}",c);
		
		a *= b;
		Console.WriteLine("a *= b: {0}", a);
		Console.WriteLine();
	}
}
