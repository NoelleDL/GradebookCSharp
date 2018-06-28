using System;
using Xunit; 
namespace Grades.Tests.Types
{
    public class ReferenceTypeTests
    {
        [Fact]
        public EmptyClass()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Noelle's Grade Book";
            Assert.Equal(g1.Name, g2.Name); 
        }
    }
}
