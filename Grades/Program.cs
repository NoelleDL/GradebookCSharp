using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook(); 
            book.AddGrade(91);
            Console.WriteLine(book); 
        }
    }
}
