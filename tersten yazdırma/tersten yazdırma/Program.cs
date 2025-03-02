using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        Console.Write("Kaç kelime gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Kelime {i + 1}: ");
            words.Add(Console.ReadLine());
        }

        Console.WriteLine("\nKelimelerin tersi:");
        words.Reverse(); 

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}
