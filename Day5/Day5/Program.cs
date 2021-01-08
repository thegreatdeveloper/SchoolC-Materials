using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DatePrinter.ParseDate();
            DatePrinter.PrintDate(date);
        }
    }
}
