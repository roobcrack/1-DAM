//Un programa que almacene en una tabla el número de días que tiene 
//cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
//un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.
using System;
class ej{
	static void Main(){
		int [] numero = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		string [] mes = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
						 "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		int i, num=0;
		bool done = false;
		
		Console.WriteLine("Introduzca un numero (dados los meses) para averiguar cuantos dias tiene");
		Console.WriteLine();
		for (i=0;i<=11;i++){
			Console.Write("{0}.{1} ",i+1,mes[i]);
		}
		Console.WriteLine();
		Console.WriteLine();
		while(!done){
			try{
				Console.Write("Inserte: ");
				num = Convert.ToInt32(Console.ReadLine());
				if((num<1) || (num>12)){
					Console.WriteLine("ERROR.Introduzca un valor del 1 al 12");
				}else{
					done=true;
				}
			}catch{
				Console.WriteLine("ERROR.Introduzca un valor del 1 al 12");
			}
		}
		
		Console.WriteLine("El mes de {0}, tiene {1} dias.",mes[num-1],numero[num-1]);

	}
}
