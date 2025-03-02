using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> notlar = new List<int>();

        Console.Write("Kaç adet not gireceksiniz? ");
        int count = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < count; i++)
        {
            Console.Write($"{i + 1}. notu girin: ");
            int not = int.Parse(Console.ReadLine());
            notlar.Add(not);
        }

        Console.WriteLine("Orijinal Notlar: " + string.Join(", ", notlar));

        for (int i = 0; i < notlar.Count; i++)
        {
            if (notlar[i] < 50)
            {
                notlar[i] = 50;
            }
        }

        Console.WriteLine("Güncellenmiş Notlar: " + string.Join(", ", notlar));
    }
}

