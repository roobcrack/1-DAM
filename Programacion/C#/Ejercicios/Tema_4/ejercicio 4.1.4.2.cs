/*Crea una variante del ejemplo 04_01_04a que añada un dato introducido 
por el usuario al final de los datos existentes.*/
using System;
class ej{
	static void Main(){
		int [] data = {1, 2, 3, 4, 12, 43, 4, 5, 0};
		int number=1;
		bool done=false;
		
		while(!done){
			try{
				Console.Write("Enter a number to our data base: ");
				data[8] = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				if(data[8]==0){
					Console.WriteLine("ERROR.You can't enter a 0 in our data base.\n");
				}else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
		Console.WriteLine("Enter a number to see if it is in our data base, to exit type 0: ");
		do{
			try{
				Console.Write("Insert: ");
				number = Convert.ToInt32(Console.ReadLine());
				for(int i=0;i<=8;i++){
					if(number==data[i]){
						Console.WriteLine("{0} is in the position {1}",data[i],i+1);
					}
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}while(number!=0);
	}
}
