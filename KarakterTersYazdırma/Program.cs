using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Stringleri ayırarak girin: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(new char[] {  ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string str in inputArray)
        {
            string output = SwapCharactersWithPrevious(str);
            Console.Write(" " + output + " ");
        }
    }

    static string SwapCharactersWithPrevious(string input)
    {
        char[] charArray = input.ToCharArray();

        for (int i = 1; i < charArray.Length; i++)
        {
            char temp = charArray[i];
            charArray[i] = charArray[i - 1];
            charArray[i - 1] = temp;
        }

        return new string(charArray);
    }
}
