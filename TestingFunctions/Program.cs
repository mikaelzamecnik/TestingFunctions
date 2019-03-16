using System;

namespace TestingFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, string> func = FullName;
            // Using a function as an argument
            string name = func("Mikael", "Zamecnik");
            Console.WriteLine(name);
            Console.ReadLine();
        }
        public static string FullName(string a, string b)
        {
            string str = string.Format("My name is {0}",
                (a +" "+ b));
            return str;
        }

    }
}
