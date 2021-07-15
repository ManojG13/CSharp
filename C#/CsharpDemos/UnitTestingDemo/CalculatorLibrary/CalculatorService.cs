using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public class CalculatorService
    {
        public static int Add(int firstNumber,int secondNumber)
        {
            
            return firstNumber + secondNumber;
        }
        public static int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
    }
}
