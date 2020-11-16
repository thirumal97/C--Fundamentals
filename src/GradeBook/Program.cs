using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
        var grades = new List<double>() { 11.3, 11.4, 12.3 };
        grades.Add(44.2);
        var result = 0.0;
        foreach(var number in grades)
        {
            result += number;
        }
        result /= grades.Count;

        Console.WriteLine($"The result is {result:N1}");
        Console.WriteLine("Hello Thirumal and welcome to the program!");
        }
    }
}
