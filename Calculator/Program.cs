using System;

namespace Calculator
{
    class Program
    {
        //Title of the application
        const string TITLE = "Console Calculator in C#";
        
        //Method for arithmetic operations
        static double Operation(double num1, double num2, string code)
        {
            //Add switch to perform operations according to code
            double result = Double.NaN;
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
            return result;
        }

        static void Main(string[] args)
        {
            //Declare variables and initialize to zero
            double num1 = 0, num2 = 0;

            //Display title of the application
            Console.WriteLine(TITLE);
            Console.WriteLine("------------------------");

            //Use Try Catch block to handle errors
            try
            {
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

                //Assign the return value of Operation method in result variable
                double result = Operation(num1, num2, code);

                //Display the result
                if (Double.IsNaN(result))
                {
                    Console.WriteLine("No arithmetic operation was performed. Check errors and inputs.");
                }
                else if (Double.IsInfinity(result)){
                    Console.WriteLine("Result: Infinity");
                }
                else
                {
                    Console.WriteLine($"Result: {result:F2}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Oops! An error occured: " + e.Message);
            }

            //Ask user to press any key to close application
            Console.WriteLine("Press any key to close the app");
            Console.ReadKey();
        }
    }
}
