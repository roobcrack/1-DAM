/*Crea una variante del ejemplo 04_01_04a que pida al usuario el dato a buscar,
avise si ese dato no aparece, y que diga cuántas veces se ha encontrado en caso contrario.*/
using System;
class ej{
	static void Main(){
		int [] data = {1, 2, 3, 4, 12, 43, 4, 5};
		int number=1;
		
		Console.WriteLine("Enter a number to see if it is in our data base, to exit type 0: ");
		do{
			try{
				Console.Write("Insert: ");
				number = Convert.ToInt32(Console.ReadLine());
				for(int i=0;i<=7;i++){
					if(number==data[i]){
						Console.WriteLine("{0} is in the position {1}",data[i],i+1);
					}
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}while(number!=0);
	}
}
