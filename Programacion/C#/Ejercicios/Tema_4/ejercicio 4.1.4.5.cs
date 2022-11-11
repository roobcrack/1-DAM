/*Crea un programa que prepare espacio para un máximo de 10 nombres. 
Deberá mostrar al usuario un menú que le permita realizar las siguientes operaciones:
Mostrar, añadir, eliminar, salir*/
using System;
class ej{
	static void Main(){
		string [] names = {"Paco", "Pepe", "Pere", "Chiko", "Periquito", "Esteban", "Joan", "Ricardo", "Pipo", "Ivan"};
		string [] options = {"Print all names", "Add a name in a position", "Delete a name", "Quit the program"};
		string name="example";
		int option=-1, maxString=0, timesSpace, position=0, namesLength=10;
		bool done=false;
		
		while(option!=4){
			try{
				for(int i=0;i<options.Length;i++){
					if(options[i].Length>maxString){
						maxString=options[i].Length;
					}
				}
				
				for(int i=0;i<=40;i++){Console.Write("-");}
				
				Console.WriteLine("\nHere you have the menu with all the things you can do.");
				for(int i=0;i<options.Length;i++){
					timesSpace = maxString - options[i].Length;
					string space = new string(' ', timesSpace);
					Console.WriteLine("||Option {0}: {1}.{2}||",i+1,options[i],space);
				}
				
				Console.Write("Insert: ");
				option = Convert.ToInt32(Console.ReadLine());
			}catch(Exception e){Console.WriteLine(e.Message+"\n");}
			
			
			for(int i=0;i<=40;i++){Console.Write("-");}
			Console.WriteLine();

			switch(option){
				case 1: Console.WriteLine("|{0}| has been selected.\n",options[0]);
						Console.WriteLine("Here you have all the names in our data base: ");
						for(int i=0;i<namesLength;i++){
							Console.Write("{0}.{1} ",i+1,names[i]);
						}
						Console.WriteLine();Console.WriteLine(); break;
						
				case 2: Console.WriteLine("|{0}| has been selected.\n",options[1]);
						while(!done){
							try{
								Console.Write("Select in what position you want to add: ");
								position = Convert.ToInt32(Console.ReadLine());
								
								if(position==0){
									Console.WriteLine("ERROR.There's none position 0\n");
								}else if(position>names.Length){
									Console.WriteLine("ERROR.You can't enter a number bigger than {0}.\n",names.Length);
								}else{done=true;}
							}catch(Exception e){Console.WriteLine(e.Message+"\n");}
						}

						done = false;
						Console.Write("Insert the new string: ");
						name = Console.ReadLine(); 
						
						for(int i=namesLength; i > position; i--){
							names[i] = names[i-1];
						}
						names[position] = name;
						namesLength++;
						 break;
								
				case 3: Console.WriteLine("|{0}| has been selected.\n",options[2]);
						while(!done){
							try{
								Console.Write("Select in what position you want to remove: ");
								position = Convert.ToInt32(Console.ReadLine());
								
								name = names[position-1];
								
								if(position==0){
									Console.WriteLine("ERROR.There's none position 0\n");
								}else if(position>names.Length){
									Console.WriteLine("ERROR.You can't enter a number bigger than {0}.\n",names.Length);
								}else{done=true;}
							}catch(Exception e){Console.WriteLine(e.Message+"\n");}
						}
									
						for (int i=position-1;i<namesLength-1;i++) {
							names[i] = names[i + 1];
						} 
						namesLength--; 
						Console.WriteLine("Name \"{0}\" has been removed.",name); break;
				
				case 4: Console.WriteLine("|{0}| has been selected.\n",options[3]); break;
				
				default: if(option!=0){Console.WriteLine("ERROR.Enter a valid number\n");} break;
			}
		}
	}
}
