using System;

namespace DelegateDemo2
{

    //public delegate void Print();
    
    class Program
    {
        static void PrintInConsole()
        {
            Console.WriteLine("Demo");
        }

        static void PrintData(int x)
        {
            Console.WriteLine(x);
        }

        static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate demo2");

            //Print print = PrintInConsole;
            //print();
            //Action Delegate

            Action printDelegate = PrintInConsole;
            printDelegate();

            Action<int> printDel = PrintData;
            printDel(5);


            //Func delegate

            Func<int, int, int> printFunc = Add;
            int result= printFunc(5, 5);

            //Predicate delgate           
            Predicate<string> isUpper = IsUpperCase;
            bool finalResult = isUpper("Hello");
            Console.WriteLine(finalResult);
        }

        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }
    }
}
