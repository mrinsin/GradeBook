using NUnit.Framework;
using System;
using Grades;

namespace UnitTests
{
    [TestFixture()]
    public class GradeBookTests
    {
        [Test()]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(99);
            book.AddGrade(23);

            GradeStatistics stats = book.ComputeStatistics();
            Assert.AreEqual(99, stats.HighestGrade);
        }

		[Test()]
		public void ComputesLowestGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(99);
			book.AddGrade(23);

			GradeStatistics stats = book.ComputeStatistics();
			Assert.AreEqual(23, stats.LowestGrade);
		}

		[Test()]
		public void ComputesAverageGrade()
		{
			GradeBook book = new GradeBook();
			book.AddGrade(90);
			book.AddGrade(30);

			GradeStatistics stats = book.ComputeStatistics();
			Assert.AreEqual(60, stats.AverageGrade);
		}
    }
}
