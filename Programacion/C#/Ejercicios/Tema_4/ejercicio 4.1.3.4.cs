//Un programa que almacene en una tabla el número de días que tiene 
//cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para 
//febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año (por
//ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 365).
using System;
class ej{
	static void Main(){
		int [] numero = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		string [] mes = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto",
						 "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		int i,num=0, dia=0, suma=0;
		
		Console.WriteLine("Introduzca un numero dado el mes al que corresponde: ");
		Console.WriteLine();
		for (i=0;i<=11;i++){
			Console.Write("{0}.{1} ",i+1,mes[i]);
		}
		Console.WriteLine();
		Console.Write("Inserte: ");
		num = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Introduzca un dia de dicho mes, como maximo {0}: ",numero[num-1]);
		Console.Write("Inserte: ");
		dia = Convert.ToInt32(Console.ReadLine());

		for(i=0;i<=num-2;i++){
			suma = suma + numero[i];
		}
		suma = suma + dia;

		Console.WriteLine();
		Console.WriteLine("El {0} de {1} seria el numero {2}.",dia,mes[num-1],suma);
	}
}
