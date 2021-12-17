using System;

namespace VogCodeChallenge.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionClass.NamesList.ForEach((x) => Console.WriteLine("Name = {0}", x));
            
            Console.WriteLine("Case A: " + TESTModule(1));
            Console.WriteLine("Case B: " + TESTModule(7));
            Console.WriteLine("Case C: " + TESTModule(-1));
            Console.WriteLine("Case D: " + TESTModule(1.0f));
            Console.WriteLine("Case E: " + TESTModule("Hello"));
        }


        static object TESTModule(object obj)
        {
            object value;
            switch (obj)
            {
                case int n when (n >= 1 && n <= 4):
                    value = n * 2;
                    break;
                case int n when (n > 4):
                    value = n * 3;
                    break;
                case int n when (n < 1):
                    value = new ArithmeticException("Provided Value is Zero/Negative");
                    break;
                case float d when (d == 1.0f || d == 2.0f):
                    value = 3.0f;
                    break;
                case string s:
                    value = s.ToUpper();
                    break;
                default:
                    value = obj;
                    break;
            }

            return value;

        }
    }
}
