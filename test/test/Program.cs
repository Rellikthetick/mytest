using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string s = Console.In.ReadLine();
            Console.Out.WriteLine("Hallo, " + s + "!");
        }
    }
}
