using System;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           QuestionClass.NamesList.ForEach((x) => Console.WriteLine("Name = {0}", x));
        }
    }
}
