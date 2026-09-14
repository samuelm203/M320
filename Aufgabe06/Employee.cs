namespace Aufgabe06;

    public class Employee
    {
        public string FullName { get; set; }
        public int EmployeeNumber { get; set; }
        public double MonthlySalary { get; set; }

        public Employee(string fullName, int employeeNumber, double monthlySalary)
        {
            FullName = fullName;
            EmployeeNumber = employeeNumber;
            MonthlySalary = monthlySalary;
        }

        public double GetYearlySalary()
        {
            return MonthlySalary * 12;
        }
    }
