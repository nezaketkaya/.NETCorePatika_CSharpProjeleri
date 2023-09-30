using System;

namespace KarakterCikarmaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metni ve indeksi girin (örnek: Metin,3):");
            string input = Console.ReadLine();

            // Kullanıcı girdisini virgül ile böler ve metin ile indeksi ayırır.
            string[] parts = input.Split(',');

            if (parts.Length == 2)
            {
                string metin = parts[0].Trim();
                if (int.TryParse(parts[1].Trim(), out int indeks))
                {
                    if (indeks >= 0 && indeks < metin.Length)
                    {
                        // Belirtilen indeksteki karakteri çıkarır ve sonucu ekrana yazar.
                        string sonuc = metin.Remove(indeks, 1);
                        Console.WriteLine("Sonuç: " + sonuc);
                    }
                    else
                    {
                        Console.WriteLine("Hatalı indeks. İndeks metin uzunluğu içinde olmalıdır.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz indeks girişi.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş formatı. Metin ve indeksi virgülle ayırın.");
            }

            Console.ReadLine();
        }
    }
}
