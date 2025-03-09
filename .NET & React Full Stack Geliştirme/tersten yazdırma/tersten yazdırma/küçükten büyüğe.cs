using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace tersten_yazdırma
{
    
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Kaç sayı gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Ortalamayı hesapla
        double average = numbers.Average();

        // Sayıları küçükten büyüğe sırala
        numbers.Sort();

        Console.WriteLine($"\nSayıların Ortalaması: {average}");
        Console.WriteLine("Küçükten büyüğe sıralı liste:");

        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
internal class küçükten_büyüğe
    {
    }


class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Kaç sayı gireceksiniz? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Ortalamayı hesapla
        double average = numbers.Average();

        // Sayıları küçükten büyüğe sırala
        numbers.Sort();

        Console.WriteLine($"\nSayıların Ortalaması: {average}");
        Console.WriteLine("Küçükten büyüğe sıralı liste:");

        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}

