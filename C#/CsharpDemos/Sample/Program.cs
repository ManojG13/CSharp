using System;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int i = 10;            
            
            Employee employee = new Employee();

            employee.FirstName = "John";
            employee.LastName = "Peter";

            Console.WriteLine($"{employee.FirstName}-${employee.LastName}");
            Console.WriteLine(employee.ToString());
        }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public override string ToString()
        {
            return $"{FirstName}-{LastName}";
        }
    }
}
