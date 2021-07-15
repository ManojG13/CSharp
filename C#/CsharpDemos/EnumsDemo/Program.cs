using System;

namespace EnumsDemo
{
    enum Gender
    {
        Male ,
        Female,
        Unknown
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enums Demo!");
            Gender gender = Gender.Male;
            switch (gender)
            {
                case Gender.Male:
                    break;

                case Gender.Female:
                    break;
            }

            int maleValue = (int)Gender.Male;

            Gender gend = (Gender)1;

           

        }
    }
}
