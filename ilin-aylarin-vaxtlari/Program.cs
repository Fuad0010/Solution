using System;

namespace ilin_aylarin_vaxtlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int adSoyad;
            int yash;
            int i;

            Console.WriteLine("Salam, adinizi soyadinizi qeyd edin.");
            adSoyad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yashinizi yazin");
            i = Convert.ToInt32(Console.ReadLine());
            
            string myString = "My String";
            int myStringLength = myString.length;
            int nrOfSpaces = 0;

            for (i = 0; i <= myStringLength)
            {
                if (myString[i] == " ")
                {
                    nrofspaces++;
                    i++;
                }
            }






        }
    }
}
