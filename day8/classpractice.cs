using System;

namespace Animals
{
  class animal
  {
   int i = 1;
   
   public int one()
   {
   return i;
   }
  }
  
  class mammal : animal
  {
  public string isMammal()
  {
   return "is mammal";
  }
  }

  class Program
  {
  static void Main()
  {
  mammal dog = new mammal();
  Console.WriteLine(dog.isMammal());
  }
  }
}
