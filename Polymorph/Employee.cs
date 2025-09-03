using System;

// Employee class implements the IQuittable interface
public class Employee : IQuittable
{
    // Property to store the employee's ID
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        // Display a message indicating the employee has quit
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
    }

    // Overload the == operator to compare two Employee objects based on their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both references point to the same object
        if (ReferenceEquals(emp1, emp2))
            return true;

        // Check if either is null
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare their Id values
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator (must be paired with ==)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Return the inverse of the == operator
        return !(emp1 == emp2);
    }

    // Override Equals to match the == operator behavior
    public override bool Equals(object obj)
    {
        var other = obj as Employee;
        if (other == null) return false;
        return this.Id == other.Id;
    }

    // Override GetHashCode to match Equals logic
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
