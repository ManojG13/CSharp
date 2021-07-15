using System;

namespace ValueTypesReferenceTypes
{
    class Person
    {
        public string FirstName { get; set; }
    }
    class Program
    {
        static void ChangeNumber(int num)
        {
            num = 200;
            Console.WriteLine($"Value of number in ChangeNumber function is {num}");
        }

        static void ChangePersonName(Person p) // reference of person object
        {
            p.FirstName = "Tina";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Value Type Demo");
            Console.WriteLine("*******************************************");
            int number = 100;
            Console.WriteLine($"Initial Number is {number}");
            ChangeNumber(number);
            Console.WriteLine($"Final value of number is {number}");

            Console.WriteLine("Reference Type Demo");
            Console.WriteLine("*******************************************");
            Person person = new Person();
            person.FirstName = "Tommy";
            Console.WriteLine($"Initial name is {person.FirstName}");
            ChangePersonName(person); // reference of person object is passed.
            //If reference is passed and if you modify any property then it will be affected everywhere.
            Console.WriteLine($"Final name is {person.FirstName}");


        }
    }
}
