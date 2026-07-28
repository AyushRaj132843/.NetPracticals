using System;

namespace EmployeePayrollSystem
{
    // Interface
    interface IPayroll
    {
        void CalculateSalary();
        void DisplayDetails();
    }

    // Base Class
    class Employee
    {
        protected int empId;
        protected string name;
        protected double basicSalary;

        public Employee(int id, string name, double salary)
        {
            empId = id;
            this.name = name;
            basicSalary = salary;
        }
    }

    // Derived Class 1
    class FullTimeEmployee : Employee, IPayroll
    {
        double hra, da, totalSalary;

        public FullTimeEmployee(int id, string name, double salary)
            : base(id, name, salary)
        {
        }

        public void CalculateSalary()
        {
            hra = basicSalary * 0.20;
            da = basicSalary * 0.10;
            totalSalary = basicSalary + hra + da;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n------ Full Time Employee ------");
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Basic Salary: $" + basicSalary);
            Console.WriteLine("HRA         : $" + hra);
            Console.WriteLine("DA          : $" + da);
            Console.WriteLine("Total Salary: $" + totalSalary);
        }
    }

    // Derived Class 2
    class PartTimeEmployee : Employee, IPayroll
    {
        int hoursWorked;
        double hourlyRate;
        double totalSalary;

        public PartTimeEmployee(int id, string name, int hours, double rate)
            : base(id, name, 0)
        {
            hoursWorked = hours;
            hourlyRate = rate;
        }

        public void CalculateSalary()
        {
            totalSalary = hoursWorked * hourlyRate;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n------ Part Time Employee ------");
            Console.WriteLine("Employee ID : " + empId);
            Console.WriteLine("Name        : " + name);
            Console.WriteLine("Hours Worked: " + hoursWorked);
            Console.WriteLine("Hourly Rate : $" + hourlyRate);
            Console.WriteLine("Total Salary: $" + totalSalary);
        }
    }

    // Main Class
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Employee Payroll System =====");

            Console.WriteLine("\nSelect Employee Type");
            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");

            Console.Write("\nEnter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            IPayroll employee;

            if (choice == 1)
            {
                Console.Write("Enter Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Basic Salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                employee = new FullTimeEmployee(id, name, salary);
            }
            else
            {
                Console.Write("Enter Employee ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Hours Worked: ");
                int hours = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Hourly Rate: ");
                double rate = Convert.ToDouble(Console.ReadLine());

                employee = new PartTimeEmployee(id, name, hours, rate);
            }

            employee.CalculateSalary();
            employee.DisplayDetails();

            Console.WriteLine("\nPress Enter to Exit...");
            Console.ReadLine();
        }
    }
}
