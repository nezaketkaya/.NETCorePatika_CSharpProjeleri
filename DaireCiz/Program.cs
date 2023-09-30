using System;

namespace CircleDrawingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius to draw a circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            CircleDrawer circleDrawer = new CircleDrawer();
            circleDrawer.DrawCircle(radius);

            Console.ReadLine();
        }
    }

    class CircleDrawer
    {
        public void DrawCircle(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            double circlePerimeter = 2 * Math.PI * radius;

            Console.WriteLine($"Area of a circle with radius {radius}: {circleArea}");
            Console.WriteLine($"Circumference of a circle with radius {radius}: {circlePerimeter}");

            // You can perform the circle drawing here.
            // To draw the circle, you can use a specialized drawing library or method.
            // For example, you can use asterisks (*) to create a simple representation.

            int circleDrawingSize = (int)radius * 2; // Adjust the size of the circle drawing based on the radius.

            for (int i = 0; i <= circleDrawingSize; i++)
            {
                for (int j = 0; j <= circleDrawingSize; j++)
                {
                    double distanceFromCenter = Math.Sqrt(Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2));

                    if (Math.Abs(distanceFromCenter - radius) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
