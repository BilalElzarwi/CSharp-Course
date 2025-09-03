using System;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee object and set its properties
            Employee emp = new Employee
            {
                Id = 1001,
                FirstName = "Bilal",
                LastName = "Elzarwi"
            };

            // Use polymorphism: assign the Employee object to a variable of type IQuittable
            IQuittable quittableEmp = emp;

            // Call the Quit() method on the interface-type object
            quittableEmp.Quit();

            // Prevent console window from closing immediately
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
