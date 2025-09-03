using System;

namespace EmployeeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first employee and assign values to properties
            Employee employee1 = new Employee
            {
                Id = 11,
                FirstName = "Bilal",
                LastName = "ELzarwi"
            };

            // Create the second employee and assign values to properties
            Employee employee2 = new Employee
            {
                Id = 1,
                FirstName = "The Rock",
                LastName = "Johnson"
            };

            // Compare the two employee objects using the overloaded == operator
            if (employee1 == employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are equal (same Id).");
            }
            else
            {
                Console.WriteLine("Employee 1 and Employee 2 are NOT equal (different Ids).");
            }

            // Also demonstrate the use of the != operator
            if (employee1 != employee2)
            {
                Console.WriteLine("Employee 1 and Employee 2 are different (based on Id).");
            }

            // Prevent the console window from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
