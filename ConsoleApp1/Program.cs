using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Enter something:");
            string txt=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You enter this:" );
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(txt);
            Console.ReadLine();
            
        }
    }
}
