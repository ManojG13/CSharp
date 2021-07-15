using System;
using CommonLibrary;
namespace ReferingProjectsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            LogInformation.Log("Message from ReferenceDemo project!!!");
            LogInformation logInformation = new LogInformation();
            logInformation.Display("Test message");
        }
    }
}
