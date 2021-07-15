using System;

namespace PropertiesDemo
{
    class Student
    {
         int id;
         string name;
         int passmark = 35;

        public int ID
        {
            set
            {
                if(value < 0)
                {
                    throw new Exception("Student Id must be greater than 0");
                }

                id = value;
            }

            get
            {
                return id;
            }
        }

        public int PassMark
        {
            get
            {
                return passmark;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be empty!");
                }

                name = value;
            }

            get
            {
                return name;
            }
        }

        public string Email
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Properties Demo!!!");

            var student = new Student();
            student.ID = 101;
            student.Name = "";
            student.Email = "abc@ther.com";
            Console.WriteLine(student.PassMark);

            
            

           

        }
    }
}
