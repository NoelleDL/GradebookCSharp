using System;
using System.Collections.Generic; 

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
           
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
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

        public string Name; 

        private List<float> grades;
    }
}
