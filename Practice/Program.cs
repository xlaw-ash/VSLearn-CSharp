using System;

namespace Practice
{
    class Program
    {
        const string TITLE = "Application for C# Practice";
        static void Main(string[] args)
        {
            //Display Title of the Program
            for(int counter = 0; counter < TITLE.Length; counter++)
            {
                Console.Write('-');
            }
            Console.WriteLine("\n" + TITLE);
            for (int counter = 0; counter < TITLE.Length; counter++)
            {
                Console.Write('-');
            }
            Console.WriteLine();

            //Display numbers between 1 and 20 (inclusive) which are divisible by 3. Also display their sum.
            int sum = 0;
            Console.Write("Numbers divisible by 3: ");
            for(int num = 1; num <= 20; num++)
            {
                if(num % 3 == 0)
                {
                    Console.Write(num + " ");
                    sum += num;
                }
            }
            Console.WriteLine($"\nSum: {sum}");

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
