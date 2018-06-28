using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.Name = "Noelle"; 
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(79); 

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name); 
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }
    }
}
