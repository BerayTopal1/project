using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç kelime gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Kelime {i + 1}: ");
            words[i] = Console.ReadLine();
        }

        FindShortestAndLongestWord(words);
    }

    static void FindShortestAndLongestWord(string[] words)
    {
        if (words.Length == 0)
        {
            Console.WriteLine("Dizi boş!");
            return;
        }

        string shortest = words[0];
        string longest = words[0];

        foreach (var word in words)
        {
            if (word.Length < shortest.Length)
                shortest = word;

            if (word.Length > longest.Length)
                longest = word;
        }

        Console.WriteLine($"\nEn kısa kelime: {shortest}");
        Console.WriteLine($"En uzun kelime: {longest}");
    }
}

