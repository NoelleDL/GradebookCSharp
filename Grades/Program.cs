using System;
using System.IO; 

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            GetBookName(book);

            book.NameChanged += OnNameChange;
            AddGrade(book);
            SaveGrades(book);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
            WriteResult("Description", stats.Description);
        }

        private static void SaveGrades(GradeBook book)
        {
            StreamWriter outputFile = File.CreateText("grades.txt");
            book.WriteGrades(outputFile);
            outputFile.Close();
        }

        private static void AddGrade(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(58);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Please enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
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
