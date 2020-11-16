using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {

        static void Main(string[] args)
        {
            var book = new Book("THirumal's book");
            book.AddGrade(80.2);
            book.AddGrade(22.2);
            book.AddGrade(33.5);
            book.ShowStatistics();
        }
    }


}
