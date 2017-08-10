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
    }
}
