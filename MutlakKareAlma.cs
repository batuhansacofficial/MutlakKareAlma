using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Her bir sayıyı boşluk ile tanımlayacak şekilde sayılar giriniz: ");
        int[] sayilar = Console.ReadLine()
                               .Split(' ')
                               .Select(int.Parse)
                               .ToArray();

        int kucuk = sayilar.Where(n => n < 67)
                                   .Select(n => 67 - n)
                                   .Sum();

        int buyuk = sayilar.Where(n => n > 67)
                                      .Select(n => (n - 67) * (n - 67))
                                      .Sum();

        Console.WriteLine($"{kucuk} {buyuk}");
    }
}