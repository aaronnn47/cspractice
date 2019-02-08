using System;

namespace Practice
{

	class solution
	{
		
		static void Main()
		{
			string problem = "hello world";
			string solution = "";
	
			for(int i = problem.Length - 1; !Char.IsWhiteSpace(problem[i]); i--)
			{
				solution += problem[i];
			}
			
			var ary = solution.ToCharArray();
			Array.Reverse(ary);
			Console.WriteLine(ary);
			
		}
	}
}
