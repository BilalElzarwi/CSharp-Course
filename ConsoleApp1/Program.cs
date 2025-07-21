using System;

class Program
{
    static void Main()
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight;
        // Try parsing the input; if it fails, exit the program
        if (!double.TryParse(Console.ReadLine(), out weight))
        {
            Console.WriteLine("Invalid input for weight. Please enter a number.");
            return;
        }

        // Check if weight exceeds 50
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program
        }

        // Prompt user to enter the package width
        Console.WriteLine("Please enter the package width:");
        double width;
        if (!double.TryParse(Console.ReadLine(), out width))
        {
            Console.WriteLine("Invalid input for width. Please enter a number.");
            return;
        }

        // Prompt user to enter the package height
        Console.WriteLine("Please enter the package height:");
        double height;
        if (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Invalid input for height. Please enter a number.");
            return;
        }

        // Prompt user to enter the package length
        Console.WriteLine("Please enter the package length:");
        double length;
        if (!double.TryParse(Console.ReadLine(), out length))
        {
            Console.WriteLine("Invalid input for length. Please enter a number.");
            return;
        }

        // Calculate the total size of the package
        double dimensionTotal = width + height + length;

        // If dimensions are too large, inform user and end program
        if (dimensionTotal > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate shipping quote using formula: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user formatted as currency
        Console.WriteLine("Your estimated total for shipping this package is: $" + quote.ToString("0.00"));
        Console.WriteLine("Thank you!");
    }
}
