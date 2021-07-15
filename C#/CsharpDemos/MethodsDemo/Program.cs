using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DisplayHelloWorld("Praveen","Raveendran");
            DisplayHelloWorld("Tim", "Correy");

            Greet();
            Greet("Tina");

            int additionResult = AddTwoNumber(2.5, 2.5);
            AddTwoNumber(5, 5);
            Console.WriteLine($"The sum of 5 and 5 is {additionResult}");
        }

        
        static void DisplayHelloWorld(string firstName,string lastName)
        {
            Console.WriteLine($"Hello {firstName} {lastName}!");
        }

        //This is a optional parameter.
        //If name is not passed it will assign name as 'Guest'.
        static void Greet(string name="Guest")
        {
            Console.WriteLine($"Hello {name}");
        }

        static int AddTwoNumber(int num1,int num2)
        {
            return num1 + num2;
        }


        //Function Overloading or Static Polymorphism
        //Ability to take more than one form. Here AddTwoNumber is having 3 different behaviour.

        static int AddTwoNumber(double num1, double num2)
        {
            return Convert.ToInt32(num1) + Convert.ToInt32(num2);
        }

        static int AddTwoNumber(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
    }
}
