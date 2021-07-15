using System;

namespace InheritanceDemo
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public void PrintFullName()
        {

        }
    }
    class FullTimeEmployee :Employee
    {       
        public float YearlySalary;        
    }

    class PartimeEmployee :Employee
    {       
       public float HourlySalary;
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Demo!!!");

            FullTimeEmployee fte = new FullTimeEmployee();
            PartimeEmployee pte = new PartimeEmployee();
            
        }
    }
}
