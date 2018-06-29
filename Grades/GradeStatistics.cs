using System;
namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;
        }
        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 89.5)
                {
                    result = "A";
                }
                else if (AverageGrade >= 79.5)
                {
                    result = "B";
                }
                else if (AverageGrade >= 69.5)
                {
                    result = "C";
                }
                else if (AverageGrade >= 59.5)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;
    }
}
