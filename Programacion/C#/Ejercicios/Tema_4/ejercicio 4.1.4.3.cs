/*Crea una variante del ejemplo 04_01_04a que inserte un dato introducido 
por el usuario en la posición que elija el usuario. Debe avisar si la posición 
escogida es incorrecta (porque esté más allá del final de los datos)*/
using System;
class ej{
	static void Main(){
		int [] data = {1, 2, 3, 4, 12, 43, 4, 5, 8};
		int number=1, position=0;
		bool done=false;
		
		do{
			try{
				Console.Write("Enter the position where you want to put the number: ");
				position = Convert.ToInt32(Console.ReadLine());
			
				if(position-1 > 8){
					Console.WriteLine("ERROR.The position can't be bigger than 9.\n");
				}else if(position==0){
					Console.WriteLine("ERROR.The position can't be 0.\n");
				}else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}while(!done);
		done=false;
		
		do{
			try{
				Console.Write("Enter a number to our data base: ");
				data[position] = Convert.ToInt32(Console.ReadLine());
				if(data[position]==0){
					Console.WriteLine("ERROR.You can't enter a 0 in our data base.\n");
				}else{done=true;}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}while(!done);
		
		done = false;
		Console.WriteLine();
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
