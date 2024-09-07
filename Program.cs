using System;

namespace ConsoleAppGit
{
    class Program
    {
        static void Main(string[] args)
        {
            SecondClass _second = new();
            Console.WriteLine(_second.GetType().ToString());
        }
    }
}
     