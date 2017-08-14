using System;
using System.Linq;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            Grades = new List<float>();
		}

		public List<float> Grades;
        public event NameChangeDelegate NameChanged;

        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException();
                }
                if (_name != value)
                {
                }
                _name = value;
            }
        }

        public void AddGrade(float grade)
        {
            Grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in Grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / Grades.Count;
            return stats;
        }
	}
}
