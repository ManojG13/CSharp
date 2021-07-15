using System;

namespace MethodHidingDemo
{
    class Employee
    {
        public string FirstName;
        public string LastName;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }

    class PartTimeEmployee : Employee
    {
        public new void PrintFullName()
        {
            //base.PrintFullName(); // Method 1 to call the parent PrintFullName
            Console.WriteLine($"{FirstName} {LastName} - Contractor");
        }
    }

    class FullTimeEmployee : Employee
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Method Hiding Demo");

            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "FullTime";
            fte.LastName = "Employee";
            fte.PrintFullName();

            float i = 10.22f;
            int j = (int)i;

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "PartTime";
            pte.LastName = "Employee";

            ((Employee)pte).PrintFullName(); // Method 2 to call the PrintFullName

            Employee emp = new PartTimeEmployee();  //// Method 3 to call the PrintFullName
            emp.FirstName = "PartTime";
            emp.LastName = "Employee";

            emp.PrintFullName();



        }
    }
}
