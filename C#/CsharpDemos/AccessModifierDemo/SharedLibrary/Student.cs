using System;

namespace SharedLibrary
{
    // default class modifier is 'internal'
   public class Student
    {
        protected int Id { get; set; }
        public void Display()
        {
            Log();
            
        }

        void Log()
        {

        }
    }
}
