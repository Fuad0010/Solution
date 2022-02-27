using System;

namespace Task___3
{
    internal class Program
    {
        static void Main(string[] args)
        {/* Task 3
            a ve b ededinin cemi 2-reqemlidirse "cem ikireqemli ededdir"
            cem 3 reqemlidirse "cem ucreqemlidir" 
            eks halda "nezere alinmayıb" cap edilsin
          */
            int a;
            int b;
            int sum;

            Console.WriteLine("Write First Number: ");
             a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Write Second Number: ");
             b = Convert.ToInt32(Console.ReadLine());
            
            sum = a + b;
            if (sum < 10 || sum > 999)
            {
                Console.WriteLine($"Cavab: {sum} nezere alinmayıb");
            }

            else if (sum < 100)
            {
                Console.WriteLine($"Cavab: {sum} ikireqemli ededdir");
            }
            else if (sum >= 100)
            {
                Console.WriteLine($"Cavab: {sum} ucreqemlidir");
            }
            
            
            

                


            

            




        }
    }
}
