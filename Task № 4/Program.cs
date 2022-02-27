using System;

namespace Task___4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*  Task 4
             a ededi 1-reqemlidirse cavabda 1-reqemli
             2-reqemlidise cavabda 2reqemli.....   
             5-reqemlidise cavabda 5reqemli cap edin
          */

                    Console.WriteLine("Write Number:");
            int a = Convert.ToInt32(Console.ReadLine());


            


            if (a < 10)
            {
                Console.WriteLine($"\"{a}\" Reqemi bir reqemlidir.");
            }
            else if (a <100)
            {
                Console.WriteLine($"\"{a}\" Reqemi iki reqemlidir.");
            }
            else if (a <1000)
            {
                Console.WriteLine($"\"{a}\" Reqemi uch reqemlidir.");
            }
            else if (a <10000)
            {
                Console.WriteLine($"\"{a}\" Reqemi dord reqemlidir.");
            }
            else if (a <100000)
            {
                Console.WriteLine($"\"{a}\" Reqemi besh reqemlidir.");
            }
        }
    }
}
