using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collections Demo");
            /*
             C# collection -> Designed to store,manage and manipulate similar data more efficiently.

            Common Functionalities
            1. Adding items to a collection
            2. Removing items
            3. Finding,Sorting
            4. Replace
            5. Capacity of collections.
             
            */

            //Non generic  collections

            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add("string data");

            int inputData = (int)arrayList[0];

            //Pls go through HashTable,Stack & Queue

            //Generic Collections.

            //List

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            string[] animals = { "Cow", "Camel", "Dog" };
            List<string> animalList = new List<string>();
            animalList.AddRange(animals);
            animalList.Insert(1, "Cat");          

           // animalList.RemoveAll(x =>x.StartsWith("C"));
            Console.WriteLine($"Number of items in animallist = {animalList.Count}");

            //IEnumerable<string> CData= animalList.Where(x => (x.StartsWith("C") || x.StartsWith("D")));

            // Console.WriteLine(CData.Count());
            //animalList.Sort();
            animalList.Reverse();
            foreach(var animal in animalList)
            {
                Console.WriteLine(animal);
            }

            Dictionary<int, string> fruits = new Dictionary<int, string>();
            fruits.Add(1, "Mango");
            fruits.Add(2, "Orange");
           // fruits.Add(1, "Apple"); //Duplicate keys are not allowed.

            foreach(var fruit in fruits)
            {
                Console.WriteLine($"Fruit key= {fruit.Key}  and value ={fruit.Value} ");
            }
            

            

         
          
        }

      
    }
}
