﻿using System;
using System.Collections.Generic;

namespace GradeBook
{	
	class Program
	{
		static void Main(string[] args)
		{			
			var book = new Book("Jano's Grade Book");
			book.GradeAdded += OnGradeAdded;
			book.GradeAdded += OnGradeAdded;
			book.GradeAdded -= OnGradeAdded;
			book.GradeAdded += OnGradeAdded;
			// OnGradeAdded added 2 times
			

			while(true)
			{
				Console.WriteLine("Enter a Grade or 'q' to quit.");
				var input = Console.ReadLine();
				if (input == "q")
				{
					break;
				}
				try
				{
					var grade = double.Parse(input);
					book.AddGrade(grade);
				}
				catch(ArgumentException ex)
				{
					Console.WriteLine(ex.Message);
				}
				catch(FormatException ex)
				{
					Console.WriteLine(ex.Message);
				}
				finally
				{
					Console.WriteLine("Finally");
				}	
			}

			var stat = book.GetStatistics();
			// book.Name = "";
			
			Console.WriteLine(Book.CATEGORY);
			Console.WriteLine($"For the book named {book.Name}");
			Console.WriteLine($"The average grade is: {stat.Average:N1}");
			Console.WriteLine($"The highest grade: {stat.High}");
			Console.WriteLine($"The lowest grade: {stat.Low}");
			Console.WriteLine($"The letter grade is: {stat.Letter}");
			// Console.WriteLine($"Number of AddGrade: {book.grades.Count}");

			book.GetBookSetName(book,"New Name");
			System.Console.WriteLine(book.Name);
		}		
		static void OnGradeAdded(object sender, EventArgs e)
		{
			Console.WriteLine("The grade was added!");			
		}
	}
}
