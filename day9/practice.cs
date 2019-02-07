using System;

namespace solutions
{
	class project
	{
		int i;
	}

	class project1 : project
	{
		public int h(int k)
		{
			i = k;
			return i;
		}
	}
	
	class solution
	{
		static void Main()
		{
			project1 proj = new project1();
			Console.WriteLine({0},proj.h(1));
		}
	}
}
		
