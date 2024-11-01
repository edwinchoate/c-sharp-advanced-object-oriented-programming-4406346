// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee {

    private static int _employeeCount;

    public Employee ()
    {
        ID = _employeeCount + 1000;
        _employeeCount++;
    }

    public static int EmployeeCount  => _employeeCount;
    public int ID {get; init;}
    public required string Department {get; set;}
    public required string FullName {get; set;}

    public virtual void AdjustPay(decimal percentage) {}

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public class HourlyEmployee : Employee {
    public HourlyEmployee() {}

    public decimal PayRate {get; set;}

    public override void AdjustPay(decimal percentage)
    {
        PayRate += (PayRate * percentage);
    }
}

public class SalariedEmployee : Employee {
    public SalariedEmployee() {}

    public decimal Salary {get; set;}

    public override void AdjustPay(decimal percentage) {
        Salary += (Salary * percentage);
    }
}
