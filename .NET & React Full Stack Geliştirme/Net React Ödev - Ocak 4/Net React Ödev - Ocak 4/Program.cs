//1’den 10’a Kadar Olan Sayıları Ekrana Yazdıran for Döngüsü
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}

//Kullanıcıdan Alınan Bir Sayıya Kadar Olan Sayıların Toplamını Hesaplayan Program
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Bir sayı girin: ");
//        int sayi = Convert.ToInt32(Console.ReadLine());

//        int toplam = 0;

//        for (int i = 1; i <= sayi; i++)
//        {
//            toplam += i;  // toplam = toplam + i;
//        }

//        Console.WriteLine("1'den " + sayi + "'e kadar olan sayıların toplamı: " + toplam);
//    }
//}

//Döngüler(for, while) Ne İşe Yarar?
//Döngüler, belirli bir kod bloğunu tekrarlamak için kullanılır. Eğer bir işlemi birden fazla kez yapmamız gerekiyorsa, döngüler bize büyük kolaylık sağlar.

//Döngü Türü	Ne Zaman Kullanılır?

//for Döngüsü	Kaç kez çalışacağını biliyorsak	
//while Döngüsü   Koşula bağlı çalışacaksa