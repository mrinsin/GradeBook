using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged = new NameChangeDelegate(OnNameChanged);
            book.NameChanged += new NameChangeDelegate(OnNameChanged2);

            book.Name = "This is a test";
			Console.WriteLine("___________________________________________");
			Console.WriteLine("Enter a grade");
            var gradeOne = Console.ReadLine();
			Console.WriteLine("___________________________________________");
			Console.WriteLine("Enter another grade");
			var gradeTwo = Console.ReadLine();
			Console.WriteLine("___________________________________________");
			Console.WriteLine("Enter a last grade");
            var gradeThree = Console.ReadLine();
			Console.WriteLine("___________________________________________");
			book.AddGrade((Convert.ToInt32(gradeOne)));
			book.AddGrade((Convert.ToInt32(gradeTwo)));
			book.AddGrade((Convert.ToInt32(gradeThree)));
			Console.WriteLine("___________________________________________");
            book.Name = "Mrinalini's First grade book";


			WriteResults(book);
		}

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Gradebook changing names from {existingName} to {newName}");
            
        }

		static void OnNameChanged2(string existingName, string newName)
		{
            Console.WriteLine("*****************");
		}

        static void WriteResults(GradeBook book)
        {
			GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("___________________________________________");
            Console.WriteLine($"Welcome to: {book.Name}");
			Console.WriteLine("___________________________________________");
			Console.WriteLine($"Class Average: {stats.AverageGrade}");
			Console.WriteLine($"Class Highest: {stats.HighestGrade}");
			Console.WriteLine($"Class Lowest: {stats.LowestGrade}");
        }

    }
}
