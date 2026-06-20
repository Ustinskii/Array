using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var arr = Enumerable.Range(0, 15).Select(_ =>
        {
            Console.Write("Число: ");
            return int.Parse(Console.ReadLine());
        }).ToList();

        int k = int.Parse(Console.ReadLine());
        if (k < 0 || k > 14)
        {
            Console.WriteLine("k вне диапазона");
            return;
        }

        arr = arr.Take(k).Reverse().Concat(arr.Skip(k).Reverse()).ToList();
        Console.WriteLine("Результат: " + string.Join(", ", arr));
    }
}
