//Ruben Martinez Martinez
using System;
class Ejercicio_3_1_3{
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
							Ejercicio_3_1_3_1(); break;
					case 2: Console.WriteLine(); 
							Ejercicio_3_1_3_2(); break;	
					default: if(ejercicio!=0){
								Console.WriteLine("ERROR.Introduzca un valor valido por favor");
								Console.WriteLine(); 
							 } break;
							
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}
	
//Crea un programa que use tres variables enteras x,y,z. Sus valores 
//iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas 
//variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado 
//obtenido por el programa.
	static void Ejercicio_3_1_3_1(){
		int x=15, y=-10, a, b;
		long z=2147483647, c;
		
		a = x++;
		Console.WriteLine("x vaele {0}", a);
		Console.WriteLine("Si lo incrementamos vale {0}", x);
 
		b = y++;
		Console.WriteLine("b vale {0}", b);
		Console.WriteLine("Si lo incrementamos vale {0}", y);
		
		c = z++;
		Console.WriteLine("z vale {0}",c);
		Console.WriteLine("Si lo incrementamos vale {0}",z);
		Console.WriteLine();
	}
	
//¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; 
//b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para 
//ver si habías hallado la solución correcta.
	static void Ejercicio_3_1_3_2(){
		int a = 5;
		Console.WriteLine("a = 5: {0}",a);
		
		int b = ++a;
		Console.WriteLine("b = ++a: {0}",b);
		
		int c = a++;
		Console.WriteLine("c = a++: {0}",c);
		
		b = b * 5;
		Console.WriteLine("b = b * 5: {0}",b);
		
		a = a * 2;
		Console.WriteLine("a = a * 2: {0}",a);
		Console.WriteLine();
	}
}
