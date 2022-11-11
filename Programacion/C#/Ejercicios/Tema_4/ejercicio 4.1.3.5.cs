//A partir del ejercicio anterior, crea otro que pida al usuario que le indique 
//la fecha, formada por día (1 al 31) y el mes (1=enero, 12=diciembre), y como 
//respuesta muestre en pantalla el número de días que quedan hasta final de año.
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
		dia = Convert.ToInt32(Console.ReadLine());

		for(i=12;i>=num;i--){
			suma = suma + numero[i-1];
		}
		suma = suma - dia;

		Console.WriteLine("Quedan {0} dias para fin de año.",suma);
	}
}
