using System;

class Program
{
    static void Main()
    {
        int sayi;

        while (true)
        {
            Console.Write("10 ile 100 arasında bir sayı girin: ");
            if (int.TryParse(Console.ReadLine(), out sayi) && sayi >= 10 && sayi <= 100)
            {
                break; 
            }
            Console.WriteLine("Hatalı giriş! Lütfen tekrar deneyin.");
        }

        Console.WriteLine("Geçerli sayı girildi: " + sayi);
    }
}
