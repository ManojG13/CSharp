using System;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // C# User Input demo

            /*
             * 
            Console.WriteLine("What is your age?");
            string inputage = Console.ReadLine();
            int age = Convert.ToInt32(inputage);
            Console.WriteLine($"Your age is {age}");

            */

            //Arithmetic Operators

            int sum = 5 + 4;
            int diff = 5 - 4;
            int mul = 5 * 4;
            int div = 5 / 4;
            int rem = 5 % 4;
            Console.WriteLine($"Division result = {div}");
            Console.WriteLine($"Reminder result = {rem}");

            //Assignment opeartors;

            int x = 5;

            //Comparison operators
            int y = 5;
            Console.WriteLine(x == y);

            // Strings

            string firstName = "Tim Teresa";
            Console.WriteLine(firstName.Length);
            Console.WriteLine(firstName.ToUpper());

            //Conditional Operators

            // Or operator -> ||

            /*
            if (firstName.Length <=5)
            {
                Console.WriteLine("length <=5");
            }
            else if (firstName.Length>5 && firstName.Length<8)
            {
                Console.WriteLine("lenght >5 and <8");
            }
            else
            {
                Console.WriteLine("you are unlucky");
            }

            //Short hand if or ternary operator.

            int salary = 5000;

            if(salary > 5000)
            {
                Console.WriteLine("you are promoted");
            }
            else
            {
                Console.WriteLine("No promotion to you!");
            }

            string promotion = (salary > 5000) ? "you are promoted" : "No promotion to you!";
            Console.WriteLine(promotion);
            */


            //Switch statements.

            int currentDay = 2;

            switch (currentDay)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                default:
                    Console.WriteLine("You are not in this planet");
                    break;
            }
        }
    }
}
