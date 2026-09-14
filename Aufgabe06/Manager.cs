namespace Aufgabe06;

public class Manager : Employee
{
    private double _bonus;

    public Manager(string fullName, int employeeNumber, double monthlySalary, double bonus) 
        : base(fullName, employeeNumber, monthlySalary)
    {
        _bonus = bonus;
    }

    public new double GetYearlySalary()
    {
        return base.GetYearlySalary() + _bonus;
    }
}