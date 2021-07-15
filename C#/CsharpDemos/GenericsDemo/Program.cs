using System;

namespace GenericsDemo
{

    public class Checker
    {
        public static bool AreEqual<T>(T value1,T value2)
        {
            return value1.Equals(value2);
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Checker.AreEqual<int>(4, 5);
        }
    }

    
    public abstract class GenericCalculator<T>
    {
        public abstract T Add(T firtNumber, T secondNumber);
    }

    public class IntegerCalulator : GenericCalculator<int>
    {
        public override int Add(int firtNumber, int secondNumber)
        {
            return firtNumber + secondNumber;
        }
    }

    public class DecimalCalculator : GenericCalculator<decimal>
    {
        public override decimal Add(decimal firtNumber, decimal secondNumber)
        {
            return firtNumber + secondNumber;
        }
    }


}
