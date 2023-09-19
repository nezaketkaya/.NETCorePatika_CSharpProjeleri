using System;

namespace FibonacciOrtalamasi
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Fibonacci serisinin derinliğini girin:");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            double ortalama = FibonacciOrtalamasiHesaplayici.HesaplaOrtalama(derinlik);

            Console.WriteLine($"Fibonacci serisinin ilk {derinlik} terimi ortalaması: {ortalama}");
            Console.ReadLine();
        }
       
    }

    public static class FibonacciOrtalamasiHesaplayici
    {
        public static double HesaplaOrtalama(int derinlik)
        {
            double toplam = 0;
            int oncekiTerim = 0;
            int suankiTerim = 1;

            for (int i = 0; i < derinlik; i++)
            {
                int yeniTerim = oncekiTerim + suankiTerim;
                toplam += yeniTerim;

                oncekiTerim = suankiTerim;
                suankiTerim = yeniTerim;
            }

            return toplam / derinlik;
        }
    }
}
