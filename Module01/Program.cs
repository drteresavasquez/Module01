using System;

namespace Module01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pause();
        }

        static void Pause()
        {
            Console.WriteLine("press Enter to continue...");
            Console.ReadLine();
        }
    }
}