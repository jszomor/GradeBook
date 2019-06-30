using System;
using System.Collections.Generic;

namespace GradeBook
{	
	class Program
	{
		static void Main(string[] args)
		{	
			var book = new Book("Jano's Grade Book");
			book.AddGrade(88.5);
			book.AddGrade(90.5);
			book.AddGrade(77.3);

			var stat = book.GetStatistics();
			Console.WriteLine($"The average grade is: {stat.Average:N1}");
			Console.WriteLine($"The highest grade: {stat.High}");
			Console.WriteLine($"The lowest grade: {stat.Low}");
			// Console.WriteLine($"Number of AddGrade: {book.grades.Count}");

			book.GetBookSetName(book,"New Name");
			System.Console.WriteLine(book.Name);
		
					
		}
	}
}
