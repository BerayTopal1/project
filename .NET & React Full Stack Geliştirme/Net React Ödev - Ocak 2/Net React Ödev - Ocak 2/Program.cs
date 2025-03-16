using System;

class Program
{
    static void Main()
    {
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        int toplam = sayi1 + sayi2;

        Console.WriteLine("Toplam: " + toplam);
    }
}



//C#’ta Kullanılan Temel Veri Tipleri

//✅ Değer Tipleri (Value Types)
//Bellekte Stack alanında saklanır ve doğrudan değer tutar.

//Veri Tipi	Açıklama	Bellek Kullanımı
//int	Tam sayılar (32-bit)	4 byte
//double	Ondalıklı sayılar (64-bit)	8 byte
//float	Ondalıklı sayılar (32-bit)	4 byte
//char	Tek bir karakter (16-bit)	2 byte
//bool	true veya false	1 byte
//long	Büyük tam sayılar (64-bit)	8 byte
//short	Küçük tam sayılar (16-bit)	2 byte
//byte	0-255 arası değerler (8-bit)	1 byte
//    ✅ Referans Tipleri (Reference Types)
//Bellekte Heap alanında saklanır ve veriye bir adres ile erişilir.

//Veri Tipi	Açıklama
//string	Karakter dizileri
//object	Tüm veri tiplerinin temel sınıfı
//array	Dizi (Aynı türde veri koleksiyonu)
//class Nesne yönelimli programlama sınıfı

//   Bellek Kullanımı Karşılaştırması
//    int x = 5;
//double y = 5.2;
//string name = "Mehmet";
//int 4 byte
//double 8 byte
//string minimum 20 byte (karakter sayısına bağlı olarak değişebilir)

