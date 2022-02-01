using System;

namespace ConsoleTestingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string a1 = "\t";
            bool xx = string.IsNullOrWhiteSpace(a1);

            Console.WriteLine("Hello World!" + xx);
        }
    }
}
