
using System;

class Program
{
    static void Permute(char[] chars, int index)
    {
        if (index == chars.Length)
        {
            Console.Write(new string(chars) + ", ");
            return;
        }

        for (int i = index; i < chars.Length; i++)
        {

            char temp = chars[index];
            chars[index] = chars[i];
            chars[i] = temp;

            Permute(chars, index + 1);

            temp = chars[index];
            chars[index] = chars[i];
            chars[i] = temp;
        }
    }

    static void Main()
    {
        Console.Write("Please Enter a String: ");
        string input = Console.ReadLine() ?? "";

        Permute(input.ToCharArray(), 0);
        Console.WriteLine();
        Console.ReadKey();
    }
}
