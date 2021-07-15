using System;

namespace LoopsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop demo");

            //While
            int number = 0;
            //while (number < 5)
            //{
            //    Console.WriteLine(number);
            //    number = number + 1;
            //}

            //DO While

            //do
            //{
            //    Console.WriteLine(number);
            //    number++;

            //} while (number < 5);

            //For loop

            //for (int i=0;i<5;i++)
            //{
            //    Console.WriteLine(i);
            //}

            int[] y = new int[4];
            y[0] = 1;
            y[1] = 2;
            y[2] = 3;
            y[3]= 4;
           // y[4] = 20;

            string[] mobiles = { "iPhone", "Samsung", "LG" };

           for(int i = 0; i < y.Length; i++)
            {
                Console.WriteLine(y[i]);
            }

           foreach(string mobile in mobiles)
            {
                Console.WriteLine(mobile);
            }


        }
    }
}
