using System;

namespace CsharpDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
          // This code is used to display data in the console.
          Console.WriteLine("Hello World!");

            //Data Types.

            //Boolean
            bool b = true;
            b = false;


            //Max value of int - int.MaxValue.
            //Min Value of int - int.MinValue.
            int x = 123;
            float y = 13.2233f;

            Console.WriteLine("Max value of int is " + int.MaxValue);
            Console.WriteLine("Max value of float is" + float.MaxValue);
            Console.WriteLine("Max value of double is" + double.MaxValue);
            string name = "56666";
            double d = 123456.333;

            //Data Type Conversions

            //Implicit Conversion
            int i = 100;
            float f = i;

            //Explicit Conversion.
            float num1 = 100.22f;
            int num2 = (int) num1; // Method1 to type cast
            int num3 = Convert.ToInt32(num1); //Method 2 to type cast
            Console.WriteLine(num2);
            Console.WriteLine(num3);


            //String Operations

            string fname = "John";
            string lname = "Peter";
            Console.WriteLine(fname + " "+ lname);

            Console.WriteLine($"{fname} {lname}");

            Console.WriteLine("Your firstname is " + fname + "and your last name is " + lname);
            Console.WriteLine($"Your firstname is {fname} and your last name is {lname} ");













        }
    }
}
