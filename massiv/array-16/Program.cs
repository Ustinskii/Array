using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Сначала вводим 15 чисел с проверкой на корректность
        Console.WriteLine("Введите 15 целых чисел:");
        var arr = Enumerable.Range(0, 15).Select((_, index) =>
        {
            while (true)
            {
                Console.Write($"Число {index + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    return num;
                }
                Console.WriteLine("Ошибка! Введите корректное целое число.");
            }
        }).ToList();

        // 2. После этого вводим индекс k
        Console.Write("Введите индекс k (от 0 до 14): ");
        if (!int.TryParse(Console.ReadLine(), out int k) || k < 0 || k > 14)
        {
            Console.WriteLine("Ошибка: k вне диапазона или введено неверно.");
            return;
        }

        // 3. Раздельный реверс двух частей списка
        var result = arr.Take(k).Reverse().Concat(arr.Skip(k).Reverse()).ToList();

        // 4. Вывод результата
        Console.WriteLine("Результат: " + string.Join(", ", result));
        // 5. Ожидание нажатия клавиши, чтобы консоль не закрылась
        Console.WriteLine("\nРабота программы завершена. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}
