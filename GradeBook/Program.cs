using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(93);
            book.AddGrade(89.5f);
			book.AddGrade(46);
			book.AddGrade(97);
			book.AddGrade(84);

			GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($"Class average: {stats.AverageGrade}");
			Console.WriteLine($"Class Highest: {stats.HighestGrade}");
			Console.WriteLine($"Class Lowest: {stats.LowestGrade}");
		}
    }
}
