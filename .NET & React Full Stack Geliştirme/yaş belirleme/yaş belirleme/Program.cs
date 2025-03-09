using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> yaslar = new List<int>();

        Console.Write("Kaç kişinin yaşını gireceksiniz? ");
        int kisiSayisi = int.Parse(Console.ReadLine());

        for (int i = 0; i < kisiSayisi; i++)
        {
            Console.Write($"{i + 1}. kişinin yaşını girin: ");
            yaslar.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine("\nYaş Kategorileri:");
        foreach (int yas in yaslar)
        {
            string kategori;

            if (yas >= 0 && yas <= 12)
                kategori = "Çocuk";
            else if (yas >= 13 && yas <= 19)
                kategori = "Genç";
            else if (yas >= 20 && yas <= 64)
                kategori = "Yetişkin";
            else
                kategori = "Yaşlı";

            Console.WriteLine($"Yaş: {yas} - Kategori: {kategori}");
        }
    }
}


