using System;

namespace Task___5
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 5
          a ededi b ededine tam bolunurse tam bolunur
          eks halda bolunmur
         */
            Console.WriteLine("Write First Number: ");
         int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Second Number");
         int b = Convert.ToInt32(Console.ReadLine());
            int c = a % b;
         if (c == 0)
            {
                Console.WriteLine("Tam bolunur");
            }
         else
            {
                Console.WriteLine("Bolunmur");
            }


        }
    }
}
