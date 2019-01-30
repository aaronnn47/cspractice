using System;

class Mammal{

	public string isMammal(){
	return "is mammal";
	}

	static void Main(){
	
	Mammal dog = new Mammal();
		
	Console.WriteLine(dog.isMammal());
	}
}
