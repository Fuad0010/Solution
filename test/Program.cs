using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        { /*  jkfsndsaknskdlj  */


            Console.WriteLine("3 reqemden chox nese yazin ki qaliqi tapsin: ");

            int a = Convert.ToInt32(Console.ReadLine());

            int qaliq = a % 3;

            if (a <= 2)
            {
                Console.WriteLine("Sechdiyiniz reqemden qaliq tapilmir."); // dfnsdjkfnlfknsa
            }
            else 
            {
                // Console.WriteLine("Qaliq " + qaliq + " -dir.");

                Console.WriteLine($"Qaliq: {qaliq} -dir");

            }






        }
    }
}
