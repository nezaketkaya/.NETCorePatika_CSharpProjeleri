using System;

namespace UcgenCizmeUygulamasi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Üçgenin boyutunu girin:");
            int boyut = Convert.ToInt32(Console.ReadLine());

            UcgenCiz.CizUcgen(boyut);
        }
    }

    public static class UcgenCiz
    {
        public static void CizUcgen(int boyut)
        {
            for (int i = 1; i <= boyut; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
