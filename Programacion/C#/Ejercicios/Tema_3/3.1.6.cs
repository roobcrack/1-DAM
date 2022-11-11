//Crea un programa que pida al número del 0 al 255 y muestre el resultado 
//de hacer un XOR con un cierto dato prefijado (y también en ese rango). 
//Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor 5 = 131).
// Ruben Martinez Martinez

using System;
class Ejercicio_3_1_6{
	static void Main(){
		int n1=0, res;
		
		while(n1==0){
			try{
				Console.Write("Introduzca un numero del 0 al 255: ");
				n1 = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
		
		res = n1 ^ 5;
		
		Console.WriteLine("{0} xor 5 = {1}",n1,res);
		
		Console.WriteLine("Y como se puede ver la operacion es reversible: {0} xor 5 = {1}",res,n1);
	}
}
