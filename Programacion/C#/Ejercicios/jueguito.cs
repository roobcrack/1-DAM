using System;
class juegardo{
	static void Main(){
		int number, sum=1, rounds;
		
		Console.Write("Number of players: ");
		number = Convert.ToInt32(Console.ReadLine());
		string [] names = new string [number];
		int [] ammount = new int [number];
		int [] insert = new int [number];
		
		for(int i=0;i<number;i++){insert[i]=1;}
		
		Console.WriteLine("Insert the names of the players: ");
		for(int i=0;i<number;i++){
			Console.Write("{0}: ",i+1);
			names[i] = Console.ReadLine();
		}
		
		Console.Write("Number of rounds: ");
		rounds = Convert.ToInt32(Console.ReadLine());

		for(int i=0;i<rounds;i++){
			Console.WriteLine("Round {0}\n",i+1);
			while(sum!=0){
				for(int j=0;j<number;j++){
					if(insert[j]!=0){
						try{
							Console.Write("{0}: ",names[j]);
							insert [j] = Convert.ToInt32(Console.ReadLine());
						}catch{}
						ammount[j]++;
						sum = 0;
						for(int z=0;z<number;z++){sum=sum+insert[z];}
					}
				}
			}
			Console.WriteLine();
			for(int c=0;c<number;c++){insert[c]=1;Console.WriteLine("{0}: {1}",names[c],ammount[c]);}
			sum=1;
			Console.WriteLine();
		}
	}
}
