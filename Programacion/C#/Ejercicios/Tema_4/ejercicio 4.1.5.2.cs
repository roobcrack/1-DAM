/* Crea una nueva versión del ejercicio 4.1.5.1, usando ".Length" en vez de 
una constante.*/
using System;
class ej{
	static void Main(){
		string [] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
		int insert;
		bool done=false;
		
		while(!done){
			try {
				Console.WriteLine("How do you want to read the months");
				Console.WriteLine("1. Normal \n2. Backwards");
				Console.Write("Insert: ");
				insert = Convert.ToInt32(Console.ReadLine());
				
				if((insert!=1)&&(insert!=2)){
					Console.WriteLine("ERROR.Type a valid value\n");
				}
				
				if(insert==1){
					Console.WriteLine("Here you have all the months\n");
					for(int i=0;i<months.Length;i++){
						Console.Write("{0} ",months[i]);
						done=true;
					}
				}else if(insert==2){
					Console.WriteLine("Here you have all the months backwards\n");
					for(int i=months.Length-1;i>-1;i--){
						Console.Write("{0} ",months[i]);
						done=true;
					}
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}
}
