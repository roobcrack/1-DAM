using System;
class ej{
	static void Main(){
		int [] ammount = new int [4];
		string [] names = {"Ruben", "Amanda", "Nacho", "Joeri"};
		int [] insert = {1, 1, 1, 1};
		
		
		for(int i=0;i<4;i++){
			Console.WriteLine("Ronda {0}\n", i+1);
			while((insert[0]==1) || (insert[1]==1) || (insert[2]==1) || (insert[3]==1)){
			if(insert[0]!=0){
				Console.Write("{0}: ",names[0]);
				insert[0] = Convert.ToInt32(Console.ReadLine());
				
				ammount[0] = ammount[0] + 1;
				Console.WriteLine(ammount[0]);
			}
			if(insert[1]!=0){
				Console.Write("{0}: ",names[1]);
				insert[1] = Convert.ToInt32(Console.ReadLine());
				
				ammount[1] = ammount[1] + 1;
				Console.WriteLine(ammount[1]);
			}
			if(insert[2]!=0){
				Console.Write("{0}: ",names[2]);
				insert[2] = Convert.ToInt32(Console.ReadLine());
				
				ammount[2] = ammount[2] + 1;
				Console.WriteLine(ammount[2]);
			}
			if(insert[3]!=0){
				Console.Write("{0}: ",names[3]);
				insert[3] = Convert.ToInt32(Console.ReadLine());
				
				ammount[3] = ammount[3] + 1;
				Console.WriteLine(ammount[3]);
			}
			}
				insert[0] = 1;insert[1] = 1;insert[2] = 1;insert[3] = 1;
			}
			for(int c=0;c<4;c++){
				Console.WriteLine("\n{0}: {1}",names[c],ammount[c]);
			}
		}
	}
