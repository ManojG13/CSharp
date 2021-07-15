using System;

namespace StaticDemo
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Static Demo!!!");

            Circle c1 = new Circle(5);
            
            
            float area1 = c1.CalculateArea();
            Console.WriteLine($"Area of c1 is {area1}");

            Circle c2 = new Circle(10);
            float area2 = c2.CalculateArea();
            Console.WriteLine($"Area of c2 is {area2}");

        }
    }
}
