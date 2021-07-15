using System;

namespace PolymorphismDemo
{
    class Employee
    {
        public string FirstName = "FN";
        public string LastName ="LN";
        public virtual void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }

    }

    class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Part Time");
        }
    }
    class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Full Time");
        }
    }

    class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} - Temporary");
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Polymorphism Demo");

            Employee[] employess = new Employee[4];
            employess[0] = new Employee();
            employess[1] = new PartTimeEmployee();
            employess[2] = new FullTimeEmployee();
            employess[3] = new TemporaryEmployee();

            foreach(Employee emp in employess)
            {
                emp.PrintFullName();
            }

            }
        }
    }
