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
                //value is an implicit parameter that represents whatever the 
                //person typed when seeting book.Name
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }
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
