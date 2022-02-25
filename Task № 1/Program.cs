using System;

namespace Task___1
{
    internal class Program
    {
        static void Main(string[] args)
        {  //  1. a - ededi 3-e bolunurse "Yes" ,bölünmürsə "No" sözünü ekranda çap edin

            
            Console.WriteLine("Reqem sechin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            

            if (a % 3 == 0)
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
