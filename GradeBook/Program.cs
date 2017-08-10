using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            Console.WriteLine("Enter a grade");
            var gradeOne = Console.ReadLine();
			Console.WriteLine("Enter another grade");
			var gradeTwo = Console.ReadLine();
            Console.WriteLine("Enter a last grade");
            var gradeThree = Console.ReadLine();
            book.AddGrade((Convert.ToInt32(gradeOne)));
			book.AddGrade((Convert.ToInt32(gradeTwo)));
			book.AddGrade((Convert.ToInt32(gradeThree)));
            book.Name = "Mrinalini's First grade book";


			WriteResults(book);
		}

        static void WriteResults(GradeBook book)
        {
			GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("______________________________________");
            Console.WriteLine($"Welcome to: {book.Name}");
			Console.WriteLine("______________________________________");
			Console.WriteLine($"Class Average: {stats.AverageGrade}");
			Console.WriteLine($"Class Highest: {stats.HighestGrade}");
			Console.WriteLine($"Class Lowest: {stats.LowestGrade}");
        }
    }
}
