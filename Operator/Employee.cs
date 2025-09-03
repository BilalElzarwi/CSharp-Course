using System;

// Define the Employee class
public class Employee
{
    // Property to store the employee's ID
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Overload the == operator to compare two Employee objects based on their Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // If both are null, they are equal
        if (ReferenceEquals(emp1, emp2))
            return true;

        // If one is null and the other is not, they are not equal
        if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
            return false;

        // Compare their Id properties
        return emp1.Id == emp2.Id;
    }

    // Overload the != operator to compare two Employee objects
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // Use the already defined == operator and negate its result
        return !(emp1 == emp2);
    }

    // Override Equals to be consistent with operator overloading
    public override bool Equals(object obj)
    {
        var other = obj as Employee;

        if (other == null)
            return false;

        return this.Id == other.Id;
    }

    // Override GetHashCode to be consistent with Equals override
    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
