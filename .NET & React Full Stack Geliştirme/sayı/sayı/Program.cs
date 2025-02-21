using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");

        
        string input = Console.ReadLine();

        if (double.TryParse(input, out double sayi))
        {
            if (sayi > 0)
            {
                Console.WriteLine("Girilen sayı pozitiftir.");
            }
            else if (sayi < 0)
            {
                Console.WriteLine("Girilen sayı negatiftir.");
            }
            else
            {
                Console.WriteLine("Girilen sayı sıfırdır.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
        }

        
        Console.ReadLine();
    }
}
