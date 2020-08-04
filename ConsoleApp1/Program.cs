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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Enter you name:");
            string name=Console.ReadLine();
            Console.WriteLine("Youre name:");
            Console.WriteLine(name);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter youre age:");
            int age=0;
            try
            {
                 age = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Incorrect Data");
            }
            Console.WriteLine("Youre age is:");
            Console.WriteLine(age);
            Console.ReadLine();
            
        }
    }
}
