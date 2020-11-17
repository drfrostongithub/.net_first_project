using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Sir!");
            Console.WriteLine("What is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date}!");
            Console.Write("\nPress any key to exit ... ");
            Console.ReadKey(false);
        }
    }
}
