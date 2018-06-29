using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged += OnNameChange; 
            book.Name = "Scott's Grade Book"; 
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(79); 

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name); 
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void OnNameChange(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}.");
        }

    }
}
