using System;

namespace Practice
{

	class solution
	{
		
		static void Main()
		{
			string solution = "hello world";
			
			for(int i = solution.Length - 1; !Char.IsWhiteSpace(solution[i]); i--)
			{
				Console.Write(solution[i]);
			}
			Console.Write('\n');
			
		}
	}
}
