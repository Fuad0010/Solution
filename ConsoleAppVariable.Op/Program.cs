using System;

namespace ConsoleAppVariable.Op
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reqemi daxil edin: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int i = 1;

            while (i <= n)
            {
                if (i % 3 == 0)

                {
                    count++;
                }
                i++;
            }
            Console.WriteLine(n + "-e qeder 3 bolunen sayi : " + count); 
            










        }
    }
}
