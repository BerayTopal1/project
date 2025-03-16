//Kullanıcıdan Değer Alarak 5 Elemanlı Bir Dizi Oluşturma ve Yazdırma
using System;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[5]; 

        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write("Dizinin " + (i + 1) + ". elemanını girin: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen Sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.Write(sayi + " ");
        }
    }
}
//Bir Dizinin İçindeki En Büyük Sayıyı Bulan Program
//    using System;

//class Program
//{
//    static void Main()
//    {
//        int[] sayilar = { 15, 48, 23, 66, 81, 99 }; 

//        int enBuyuk = sayilar[0]; 

//        foreach (int sayi in sayilar)
//        {
//            if (sayi > enBuyuk)
//            {
//                enBuyuk = sayi;
//            }
//        }

//        Console.WriteLine("Dizideki en büyük sayı: " + enBuyuk);
//    }
//}
