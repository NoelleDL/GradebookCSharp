using Grades; 
using System;
using Xunit;

namespace Grades.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();

            Assert.Equal(90, result.HighestGrade); 
        }

        [Fact]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();

            Assert.Equal(10, result.LowestGrade); 
        }
    }
}
