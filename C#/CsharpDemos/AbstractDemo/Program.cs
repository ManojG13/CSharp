using System;

namespace AbstractDemo
{
    public abstract class AbstractPhone
    {
      public abstract void Print();

      public void Common()
        {
            Console.WriteLine("Function Body");
        }

     
    }

    public class ApplePhone : AbstractPhone
    {
        public override void Print()
        {
            Console.WriteLine("This is an iPhone");
        }
    }


  
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstract class Demo!!!");
            AbstractPhone phone = new ApplePhone();
           
          
        }
    }
}
