using System;

namespace Calculator
{
    class Program
    {
        const string TITLE = "Console Calculator in C#";
        static void Main(string[] args)
        {
            //Declare variables and initialize to zero
            double num1 = 0, num2 = 0;

            //Display title of the application
            Console.WriteLine(TITLE);
            Console.WriteLine("------------------------");

            //Ask user to enter numbers
            Console.WriteLine("Enter First Number: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            num2 = Double.Parse(Console.ReadLine());

            //Ask user to choose operation
            Console.WriteLine("Enter code of operation from following list:\n" +
                "Code - \tOperation\n" +
                "add - \tAddition\n" +
                "sub - \tSubtraction\n" +
                "mul - \tMultiplication\n" +
                "div - \tDivision(Quotient)\n" +
                "mod - \tDivision(Remainder)");
            string code = Console.ReadLine().ToLower();
            double result = 0; //Declare and initialize a result variable

            //Add switch to perform operations according to code
            switch (code)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "sub":
                    result = num1 - num2;
                    break;
                case "mul":
                    result = num1 * num2;
                    break;
                case "div":
                    result = num1 / num2;
                    break;
                case "mod":
                    result = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Incorrect code entered");
                    break;
            }

            //Display the result
            Console.WriteLine($"Result: {result}");

            //Ask user to press any key to close application
            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();
        }
    }
}
