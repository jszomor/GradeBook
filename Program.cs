using System;

namespace GradeBook
{
	class Program
	{
		static void Main(string[] args)
		{
			var numbers = new[] {12.7, 10.3, 6.11};
			
			var result = 0.0;
			foreach(var number in numbers)
			{
				result += number;
			}
			System.Console.WriteLine(result);
			
			if (args.Length > 0)
			{
				Console.WriteLine($"Hello, {args[1]} ! ");				
				/*args come from launch.json where is defined
				launch.json control the run/debug of code				
				 */
			}
			else
			{
				System.Console.WriteLine("Just Hello!");
			}
		}
	}
}
