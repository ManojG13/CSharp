using System;

namespace OverRidingVsHidingDemo
{
    class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Base class print method");
        }
    }

    class ChildClass :BaseClass
    {
        //Method overriding
        public override void Print()
        {
            Console.WriteLine("Child class print method");
        }

        //Method Hiding
        /*
        public new void Print()
        {
            Console.WriteLine("Child class print method");
        }

        */

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Override Vs Hiding");            
            BaseClass b = new ChildClass();
            b.Print(); 
        }
    }
}
