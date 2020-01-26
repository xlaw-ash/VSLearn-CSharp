using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse("Jan-31-2019");
            Console.WriteLine(date.ToShortDateString());

            Console.WriteLine("Press any key to close the application.");
            Console.ReadKey();
        }
    }
}
