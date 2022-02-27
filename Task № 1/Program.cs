using System;

namespace Task___1
{
    internal class Program
    {
        static void Main(string[] args)
        {  /* Task 1 
              a - ededi 3-e bolunurse "Yes" ,
              bölünmürsə "No" sözünü ekranda çap edin
            */

            Console.WriteLine("Write Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("No");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
            




        }
    }
}
