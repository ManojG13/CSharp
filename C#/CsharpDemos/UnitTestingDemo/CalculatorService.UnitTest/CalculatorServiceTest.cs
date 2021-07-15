using System;
using Xunit;

namespace CalculatorLibrary.UnitTest
{
    public class CalculatorServiceTest
    {
        [Fact]
        public void Add_Two_Integer_Numbers_Test()
        {
            int firstNumber = 10;
            int secondNumber = 10;
            int expectedResult = 20;
            int actualResult = CalculatorService.Add(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);

        }

       

        [Fact]
        public void Subtract_Two_Integer_Numbers_Test()
        {
            int firstNumber = 10;
            int secondNumber = 10;
            int expectedResult = 0;

            int actualResult = CalculatorService.Subtract(firstNumber, secondNumber);
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
