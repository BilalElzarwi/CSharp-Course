using System;

namespace MathOperationApp
{
    // Define a class named 'MathProcessor'
    class MathProcessor
    {
        // This is a void method (doesn't return anything)
        // It takes two integer parameters: num1 and num2
        public void ProcessNumbers(int num1, int num2)
        {
            // Perform a math operation on the first integer (e.g., multiply by 2)
            int result = num1 * 2;

            // Display the result of the operation on the first integer
            Console.WriteLine("Result of num1 * 2: " + result);

            // Display the second integer
            Console.WriteLine("Second number (num2): " + num2);
        }
    }

    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the 'MathProcessor' class
            MathProcessor processor = new MathProcessor();

            // Call the method using positional arguments
            // Here, 15 will be num1 and 20 will be num2
            processor.ProcessNumbers(15, 20);

            // Call the method again, this time using named arguments
            processor.ProcessNumbers(num2: 20, num1: 7);

            // Prevent console from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
