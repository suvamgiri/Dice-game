using System;

class Program {
  public static void Main (string[] args) {
	  //Dice Game 
   Random ram = new Random();
	  
   int  username ;
    int computer ;
    int user = 0;
    int computerpoint = 0;
	  
  Console.Write("enter your number : ");
  int timetoplay = Convert.ToInt32(Console.ReadLine());
 if(timetoplay == 0)
{
Console.WriteLine("enter the number how many time you want to play");
    
  }
      
    else{
for(int i = 0; i<=timetoplay ;i++){
      Console.WriteLine("-------------------");
  Console.Write("enter to  start the game ");
 Console.ReadKey();
  
    username=ram.Next(1,7);
     Console.Write("\n your Turn : ");
    Console.WriteLine(""+username);
    Console.WriteLine("-------------------");
    Console.Write("Turn of the computer : ");
    computer=ram.Next(1,7);

    Console.WriteLine(computer);
    Console.WriteLine("-------------------");
    if(username<computer){
      Console.WriteLine("computer wins  ");
    }
    else{
      Console.WriteLine("user win ");
    }
  
  user = username;
  computerpoint =computer;
  }
   
      }
    Console.WriteLine("\n--------------------------");
    Console.WriteLine("Final Result");
        Console.WriteLine("--------------------------");
  if(user<computerpoint){
    Console.WriteLine(" sorry computer wins ");
    
  }
    else{
      Console.WriteLine("Congratulation  You  Win ");
    }
  }
}
