using System;

namespace Task___2
{
    internal class Program
    {
        static void Main (string[] args)
        {/* Task 2
            a - ededi 3-e bolunən cüt ədəddirsə "3-e bolunur cutdur" ,
            3-e bolunən tek ededdirse " 3-e bolunur tekdir"
            eks halda "3-e bolunmur" sözünü ekranda çap edin
          */

            Console.WriteLine("Write Number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 3;
            int c = a % 2;
            

            if (c == 0)
            {
                int d = a % 3;
                if (a == 0)
                    Console.WriteLine("3-e bolunmur");
                else if    (d == 0)
                {
                    Console.WriteLine("3-e bolunur cutdur");
                }
                else
                {
                    Console.WriteLine("3-e bolunmur");
                }
            }
            else if (b == 0) 
            {
                Console.WriteLine("3-e bolunur tekdir");   
            }
            else if (b == 1 || b == 2)
            {
                Console.WriteLine("3-e bolunmur");
            }
        }
    }
}
