// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {
    public Employee() {}

    // YOUR CODE GOES HERE
    public required int ID { get; init; }

    public required string Department { get; set; }

    public required string FullName { get; set; }

    public virtual void AdjustPay (decimal percentage) {}

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

// DEFINE OTHER CLASSES HERE
public class HourlyEmployee : Employee 
{
    public decimal PayRate { get; set; }

    public override void AdjustPay (decimal percentage) 
    {
        PayRate += percentage * PayRate;
    }
}

public class SalariedEmployee : Employee 
{
    public decimal Salary { get; set; }

    public override void AdjustPay (decimal percentage) 
    {
        Salary += percentage * Salary;
    }
}