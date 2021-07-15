using System;

namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom Exception Demo");
            try
            {
                Student student = new Student();
                student.StudentId = 100;
                student.StudentName = "";
                ValidateStudent(student);
            }
           
            catch(InvalidStudentNameException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void ValidateStudent(Student student)
        {
            if (string.IsNullOrEmpty(student.StudentName))
            {
                 throw new InvalidStudentNameException(student.StudentName);

                
            }
        }
    }
}
