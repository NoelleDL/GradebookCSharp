using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Noelle's Grade Book";
            grades = new List<float>();
           
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public virtual GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            float sum = 0; 
            foreach (float grade in grades)
            {
                if (grade > stats.HighestGrade)
                {
                    stats.HighestGrade = grade; 
                }
                else if (grade < stats.LowestGrade)
                {
                    stats.LowestGrade = grade; 
                }
                    
                sum += grade;

            }
            stats.AverageGrade = sum / grades.Count;
            return stats; 
        }

        public void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Argument can't be null of empty");
                }

                if (_name != value && NameChanged != null)
                   {
                       NameChangedEventArgs args = new NameChangedEventArgs();
                       args.ExistingName = _name;
                       args.NewName = value;

                       NameChanged(this, args); 
                   }

                 value = _name; 
                    
            }
        }
        public event NameChangedDelegate NameChanged; 
        private string _name; 
        protected List<float> grades;
    }
}
