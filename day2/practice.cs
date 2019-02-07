using System;

class Mammal{

	private string dog;

	public string isMammal(string type){
	this.dog = type;

	return dog;
	}

	static void Main(){
	
	Mammal dog = new Mammal();
		
	Console.WriteLine(dog.isMammal("elephant"));
	}
}
