using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        
        Console.Write("Kaç adet sayı girmek istersiniz? ");
        int count = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{i + 1}. sayıyı girin: ");
            int number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }

        
        Console.WriteLine("Girilen sayılar: " + string.Join(", ", numbers));

        
        double average = numbers.Average();
        Console.WriteLine("Sayıların ortalaması: " + average);

        numbers.Sort();
        Console.WriteLine("Sıralanmış sayılar: " + string.Join(", ", numbers));
    }
}

