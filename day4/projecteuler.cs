using System;

class project
{

  static void Main()
  {
    
    int count = 0;

    for(int i = 0; i < 1000; i++)
    {
      if(i % 3 == 0)
      {
	count = count + i;
      } 
      else if(i % 5 == 0){
        count = count + i;
      }
    }

    Console.WriteLine(count);
  }
}

