using System;

namespace DelegatesDemo
{
    class Program
    {
        public delegate void Display(string message);
        public delegate int Calculate(int firtNumber, int secondNumber);
        public delegate void IsEligibleForPromotion(string input);
        static void Main(string[] args)
        {
            IsEligibleForPromotion isEligibleForPromotion = CanBePromoted;
            Promotion("Test", isEligibleForPromotion);
        }

       
        static void CanBePromoted(string input)
        {
            if (input == "test")
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
        static void Promotion(string data,IsEligibleForPromotion isEligibleForPromotion)
        {
            isEligibleForPromotion(data);
        }
    }
}
