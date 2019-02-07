using System;

namespace Animals
{
  class animal
  {
  	protected int i;
   
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
  
  class cow : animal
  {
  	public int isMammal()
  	{
   		i = 10;
   		return i;
  	}
  }  


  class Program
  {
  	static void Main()
  {
  	mammal dog = new mammal();
  	cow Cow = new cow();
  	Console.WriteLine(Cow.isMammal());
  }
  }
}
