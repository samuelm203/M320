namespace Aufgabe06;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("Max Muster", 1001, 5500.00);
            
        Manager manager = new Manager("Petra Meier", 1002, 8500.00, 15000.00);

        Console.WriteLine("Mitarbeiter");
        Console.WriteLine($"Name:           {employee.FullName}");
        Console.WriteLine($"Mitarbeiter-Nr: {employee.EmployeeNumber}");
        Console.WriteLine($"Monatslohn:     {employee.MonthlySalary:C}");
        Console.WriteLine($"Jahreslohn:     {employee.GetYearlySalary():C}");

        Console.WriteLine();

        // Ausgabe Manager
        Console.WriteLine("Manager");
        Console.WriteLine($"Name:           {manager.FullName}");
        Console.WriteLine($"Mitarbeiter-Nr: {manager.EmployeeNumber}");
        Console.WriteLine($"Monatslohn:     {manager.MonthlySalary:C}");
        Console.WriteLine($"Jahreslohn:     {manager.GetYearlySalary():C}");

        Console.ReadLine();
    }
}