/*) Crea un programa que contenga un array con los nombres de los meses 
del año. El usuario podrá elegir entre verlos en orden natural (de Enero a 
Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el 
valor máximo del array en ambos recorridos*/
using System;
class ej{
	static void Main(){
		string [] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
		const int monthsLength=12;
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
					for(int i=0;i<monthsLength;i++){
						Console.Write("{0} ",months[i]);
						done=true;
					}
				}else if(insert==2){
					Console.WriteLine("Here you have all the months backwards\n");
					for(int i=monthsLength-1;i>-1;i--){
						Console.Write("{0} ",months[i]);
						done=true;
					}
				}
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
		}
	}
}
