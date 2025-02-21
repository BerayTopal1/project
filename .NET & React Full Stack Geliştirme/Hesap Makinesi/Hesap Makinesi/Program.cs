using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        char islem = Convert.ToChar(Console.ReadLine());

        double sonuc;

        switch (islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
                break;
            case '/':
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Hata! Bir sayı sıfıra bölünemez.");
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem girdiniz!");
                break;
        }

        
        Console.WriteLine("Çıkmak için bir tuşa basın...");
        Console.ReadKey();
    }
}


