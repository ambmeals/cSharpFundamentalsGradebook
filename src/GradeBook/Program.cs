using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Calculate Average Points");
            book.AddGrade(89.5);
            book.AddGrade(76.7);
            book.AddGrade(95.5);


            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The grade average is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

    }
}
