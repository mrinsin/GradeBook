using System;

namespace Grades
{
    class MainClass
    {
        public static void Main()
        {
            GradeBook book = new GradeBook();
            book.NameChanged += (OnNameChanged);


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

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Gradebook changing names from {args.ExistingName} to {args.NewName}");
            
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
