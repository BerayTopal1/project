﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        for (int temp = Math.Abs(sayi); temp > 0; temp /= 10)
        {
            toplam += temp % 10;
        }

        Console.WriteLine("Rakamların toplamı: " + toplam);
    }
}


