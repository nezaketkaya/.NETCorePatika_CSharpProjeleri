using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Integer ikilileri boşlukla ayırarak girin:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        if (numbers.Length % 2 != 0)
        {
            Console.WriteLine("Eksik veya tek sayıda integer girdiniz.");
            return;
        }

        List<int> results = new List<int>();

        for (int i = 0; i < numbers.Length; i += 2)
        {
            int num1 = int.Parse(numbers[i]);
            int num2 = int.Parse(numbers[i + 1]);

            if (num1 == num2)
            {
                results.Add((num1 + num2) * (num1 + num2));

            }
            else
            {
                results.Add(num1 + num2);
            }
        }

        Console.WriteLine(string.Join(" ", results));
    }
}
