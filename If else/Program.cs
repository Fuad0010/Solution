using System;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Add first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine($"a) {a} > than b) {b}");
            }
            else if (b>a)
            {
                Console.WriteLine($"b) {b} > than a) {a}");
            }
            else
            {
                Console.WriteLine($"Values is equal");
            }
        }
    }
}
