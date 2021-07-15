using System;

namespace InheritanceDemo2
{
    class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }

        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    class ChildClass:ParentClass
    {
        public ChildClass() :base("Derived class controlling parent class.")
        {
            Console.WriteLine("ChildClass Constructor Called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inhertiance Demo 2");

            ChildClass child = new ChildClass();

        }
    }
}
