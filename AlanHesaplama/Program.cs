using System;
using System.Security.Cryptography.X509Certificates;


namespace AlanHesaplama
{
class Program
{
    static void Main()
    {
        Console.WriteLine("Geometrik şekli seçin (Daire, Üçgen, Kare, Dikdörtgen, vb.):");
        string shape = Console.ReadLine().ToLower();

        double result = 0;

        switch (shape)
        {
            case "daire":
                Console.WriteLine("Dairenin yarıçapını girin: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                Circle circle = new Circle(radius);

                Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                string dimension = Console.ReadLine().ToLower();

                if (dimension == "çevre")
                {
                    result = circle.CalculatePerimeter();
                }
                else if (dimension == "alan")
                {
                    result = circle.CalculateArea();
                }
                break;

            case "üçgen":
                Console.WriteLine("Üçgenin ilk kenarını girin: ");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Üçgenin ikinci kenarını girin: ");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Üçgenin üçüncü kenarını girin: ");
                double side3 = Convert.ToDouble(Console.ReadLine());
                Triangle triangle = new Triangle(side1, side2, side3);

                Console.WriteLine("Hesaplamak istediğiniz boyutu seçin (Çevre, Alan):");
                dimension = Console.ReadLine().ToLower();

                if (dimension == "çevre")
                {
                    result = triangle.CalculatePerimeter();
                }
                else if (dimension == "alan")
                {
                    result = triangle.CalculateArea();
                }
                break;

            // Diğer geometrik şekiller için benzer şekilde devam edebilirsiniz.

            default:
                Console.WriteLine("Geçersiz bir geometrik şekil girdiniz.");
                break;

                    
            }
           
             if (result != 0)
             {
                 Console.WriteLine($"Sonuç: {result}");
             }
    }
}
}