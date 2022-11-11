//Ruben Martinez Martinez
/*Descompón en funciones la base de datos de ficheros (ejemplo 04_06a), de 
modo que el "Main" sea breve y más legible (Pista: las variables que se compartan 
entre varias funciones deberán estar fuera de todas ellas, y deberán estar 
precedidas por la palabra "static").*/
using System;
class Ejercicio_5_2_3{
	struct typeFile{
		public string nameFile;
		public long size;
	};
	
	static void Main(){
		typeFile [] files = new typeFile[1000];
		int numberFiles=0;
		string [] options = {"Add data to a new file", "Show all file names", "Show files over entered size", "See data from a file", "Quit the program"};
		int option, max=0, timesSpace;
		
		do{
			for(int i=0;i<options.Length;i++){
				if(options[i].Length>max){
					max=options[i].Length;
				}
			}
			Console.WriteLine("Choose an option");
			for(int i=0;i<max+8;i++){Console.Write("=");}
			Console.WriteLine();
			for(int i=0;i<options.Length;i++){
				timesSpace = max - options[i].Length;
				string space = new string(' ', timesSpace);
				Console.WriteLine("||{0}.- {1}{2}||",i+1,options[i],space);
			}
			for(int i=0;i<max+8;i++){Console.Write("=");}
			Console.WriteLine();
			Console.Write("Insert: ");
			option = Convert.ToInt32(Console.ReadLine());
			
			switch(option){
				case 1: numberFiles = AddDataNewFile(files, numberFiles); break;
				case 2: ShowFileNames(files, numberFiles); break;
				case 3: ShowSizeFiles(files, numberFiles); break;
				case 4: SeeFileData(files, numberFiles); break;
				case 5: Console.WriteLine("\nEnd of the program"); break;
				default: Console.WriteLine("Unknown option"); break;
			}
		}while(option!=5);
	}
	
	static int AddDataNewFile(typeFile [] files, int numberFiles){
		if(numberFiles<1000){
			Console.WriteLine("Enter the file name");
			files[numberFiles].nameFile = Console.ReadLine();
			Console.WriteLine("Enter the size in KB");
			files[numberFiles].size = Convert.ToInt32(Console.ReadLine());
			
			numberFiles++;
		}else{
			Console.WriteLine("Max size reached");
		}
		Console.WriteLine();
		return numberFiles;
	}
	
	static void ShowFileNames(typeFile [] files, int numberFiles){
		for(int i=0; i<numberFiles;i++){
			Console.WriteLine("Name: {0}; Size: {1} KB", files[i].nameFile, files[i].size);
		}
		Console.WriteLine();
	}
	
	static void ShowSizeFiles(typeFile [] files, int numberFiles){
		long sizeSearch;
		Console.WriteLine("From what size you want to search?");
		sizeSearch = Convert.ToInt64(Console.ReadLine());
		for(int i=0;i<numberFiles;i++){
			if(files[i].size >=sizeSearch){
				Console.WriteLine("Name: {0}; Size: {1} KB", files[i].nameFile, files[i].size);
			}
		}
		Console.WriteLine();
	}
	
	static void SeeFileData(typeFile [] files, int numberFiles){
		string textSearch;
		Console.WriteLine("From what file you want to see all data?");
		textSearch = Console.ReadLine();
		for(int i=0;i<numberFiles;i++){
			if(files[i].nameFile == textSearch){
				Console.WriteLine("Name: {0}; Size: {1} KB", files[i].nameFile, files[i].size);
			}
		}
		Console.WriteLine();
	}
}
