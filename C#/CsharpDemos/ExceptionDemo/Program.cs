using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Handling!!!");

            try
            {
                string s = null;
                Console.WriteLine(s.ToLower());

                int x = 5;
                int y = 0;
                Console.WriteLine(x / y);
                string[] fruits = new string[4];
                fruits[5] = "Unknown";
               
            }
            
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception");
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Division Error");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
