using System;

namespace ClassDemo
{
    class Customer
    {
         string firstName;
         string lastName;

       
        public Customer(string fName,string lName)
        {
            firstName = fName;
            lastName = lName;
        }
        public void PrintFullName()
        {
            Console.WriteLine($"Your fullname is {firstName} {lastName}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Demo!!!");
            Customer cust = new Customer("Tim","Thomas");
            
            cust.PrintFullName();
            
            
        }
    }
}
