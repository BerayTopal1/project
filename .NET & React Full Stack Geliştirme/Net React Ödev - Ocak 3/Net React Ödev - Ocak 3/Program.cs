using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Bir sayı girin: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir.");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir.");
        }
    }
}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Bir sayı girin: ");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        if (sayi > 0)
//        {
//            Console.WriteLine("Girilen sayı pozitiftir.");
//        }
//        else if (sayi < 0)
//        {
//            Console.WriteLine("Girilen sayı negatiftir.");
//        }
//        else
//        {
//            Console.WriteLine("Girilen sayı sıfırdır.");
//        }
//    }
//}

//Koşullu İfadeler(if-else) Ne İşe Yarar?
//Koşullu ifadeler (if-else), programın belirli durumlara göre farklı işlemler yapmasını sağlar. Mantıksal koşullara bağlı olarak kodun belirli bölümlerinin çalışmasını kontrol eder.

//Gerçek Hayattan Örnek:
//✅ Sınav Sonucu Değerlendirme: Eğer not 50’den büyükse geçti, değilse kaldı.
//✅ ATM Para Çekme: Eğer bakiye yeterliyse para çek, değilse uyarı ver.
//✅ Şifre Kontrolü: Eğer şifre doğruysa giriş yap, değilse hata ver.
