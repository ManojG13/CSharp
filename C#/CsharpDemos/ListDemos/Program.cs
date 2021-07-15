using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDemos
{
    class Program
    {
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("List Demo!!!");

            var numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);

            var listofNumbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(listofNumbers.Max());
            Console.WriteLine(listofNumbers.Min());
            Console.WriteLine(listofNumbers.Average());
            try
            {
                var personList = new List<Person>();
                var p1 = new Person();
                Console.WriteLine("Enter your name?");
                p1.Name = Console.ReadLine();                
                p1.Id = personList.Count > 0 ? personList.Max(x => x.Id) + 1 : 100;
                personList.Add(p1);

                var p2 = new Person();
                p2.Name = "Tim";
                p2.Id = personList.Max(x => x.Id) + 1;
                personList.Add(p2);

                foreach (var person in personList)
                {
                    Console.WriteLine($"Id = {person.Id}, Name ={person.Name}");
                }
            }
           catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
