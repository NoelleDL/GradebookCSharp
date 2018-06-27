using System;
using System.Collections.Generic; 

namespace Grades
{
    public class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>(); 
    }
}
