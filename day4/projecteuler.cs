using System;

class project
{

  static void Main()
  {
    
    int count = 0;

    for(int i = 0; i < 10; i++)
    {
      if(i % 3 == 0)
      {
	Console.WriteLine("im divisible");
      } 
      else{
        Console.WriteLine("im not");
      }
    }
  }
}

