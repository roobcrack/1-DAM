using System;
class prueba{
	static void Main(){
		string [] nombres = {"a", "b3e", "ced"};
		int maxima=0, timesSpace=0;
		
		
		for(int i=0;i<=2;i++){
			if(nombres[i].Length>maxima){
				maxima=nombres[i].Length;
			}
		}
		
		for(int i=0;i<=2;i++){
				timesSpace = maxima - nombres[i].Length;
				string space = new string(' ', timesSpace);
				Console.WriteLine("{0}.{1}{2}a",i+1,nombres[i],space);	
		}
	}
}
