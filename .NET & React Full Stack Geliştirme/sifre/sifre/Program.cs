using System;

class Program
{
    static void Main()
    {
        Console.Write("Şifrenizi girin: ");
        string sifre = Console.ReadLine();

       
        bool uzunlukUygun = sifre.Length >= 8;
        bool ozelKarakterVar = sifre.IndexOfAny(new char[] { '@', '#', '$', '%' }) != -1;
        bool buyukHarfVar = false;

        foreach (char c in sifre)
        {
            if (char.IsUpper(c))
            {
                buyukHarfVar = true;
                break;
            }
        }

        if (uzunlukUygun && ozelKarakterVar && buyukHarfVar)
        {
            Console.WriteLine("Şifreniz güçlü!");
        }
        else
        {
            Console.WriteLine("Şifreniz zayıf! Lütfen aşağıdaki kurallara uyun:");
            if (!uzunlukUygun)
                Console.WriteLine("- En az 8 karakter uzunluğunda olmalı.");
            if (!ozelKarakterVar)
                Console.WriteLine("- @, #, $, % gibi özel karakterlerden en az birini içermeli.");
            if (!buyukHarfVar)
                Console.WriteLine("- En az bir büyük harf içermeli.");
        }
    }
}

