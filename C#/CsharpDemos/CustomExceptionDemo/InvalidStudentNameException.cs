using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptionDemo
{
    class InvalidStudentNameException :Exception
    {
        public InvalidStudentNameException(string name) :base($"Name is invalid")
        {

        }
    }
}
