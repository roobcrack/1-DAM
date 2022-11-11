//Ruben Martinez Martinez
using System;
class Ejercicio_3_1_2{
	static void Main(){
		int ejercicio, i;
		bool done = false;
		
		while(!done){
			try{
				Console.WriteLine("Introduzca que ejercicio quiere probar.");
				for(i=0;i<3;i++){
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
							Ejercicio_3_1_2_1(); break;
					case 2: Console.WriteLine(); 
							Ejercicio_3_1_2_2(); break;	
					case 3: Console.WriteLine();
							Ejercicio_3_1_2_3(); break;
					default: if(ejercicio!=0){
								Console.WriteLine("ERROR.Introduzca un valor valido por favor");
								Console.WriteLine(); 
							 } break;
							
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}

//Pregunta al usuario su edad, que se guardará en un "byte". A 
//continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No 
//aparentas 20 años").
	static void Ejercicio_3_1_2_1(){
		byte edad=0;
		
		Console.WriteLine("Introduzca su edad");
		
		while(edad==0){
			try{
				edad = Convert.ToByte(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");edad=0;}
		}
		Console.WriteLine("No aparenta los {0}", edad);
		Console.WriteLine();
	}
	
//Pide al usuario dos números enteros largos ("long") y muestra su suma, su resta y su producto.
	static void Ejercicio_3_1_2_2(){
		byte n1=0, n2=0;
		
		while(n1==0){
			try{
				Console.WriteLine("Introduzca un numero");
				n1 = Convert.ToByte(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");n1=0;}
		}
		
		while(n2==0){
			try{
				Console.WriteLine("Introduzca otro numero");
				n2 = Convert.ToByte(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");n2=0;}
		}
		
		int res = n1 * n2;
		
		Console.WriteLine("\nEl el producto de ambos numeros es: {0}", res);
		Console.WriteLine();
	}

static void Ejercicio_3_1_2_3(){
		long n1=0, n2=0, res;
		
		while(n1==0){
			try{
				Console.WriteLine("Introduzca un numero");
				n1 = Convert.ToByte(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");n1=0;}
		}
		
		while(n2==0){
			try{
				Console.WriteLine("Introduzca otro numero");
				n2 = Convert.ToByte(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");n2=0;}
		}
		
		res = n1 + n2;
		Console.WriteLine("La suma de ambos numeros es {0}",res);
		
		res = n1 - n2;
		Console.WriteLine("La resta de ambos numeros es {0}",res);
		
		res = n1 * n2;
		Console.WriteLine("El producto de ambos numeros es {0}",res);
		Console.WriteLine();
	}
}
