using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Ввод массива
        List<int> arr = new List<int>();
        Console.WriteLine("Введите 15 целых чисел:");
        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Число {i + 1}: ");
            int num = int.Parse(Console.ReadLine());
            arr.Add(num);
        }

        // Ввод индекса k
        Console.Write("Введите индекс k (от 0 до 14): ");
        int k = int.Parse(Console.ReadLine());

        // Получаем результат
        List<int> reversedArray = ReverseArray(arr, k);

        // Вывод результата
        Console.WriteLine("Измененный массив: " + string.Join(", ", reversedArray));
    }

    static List<int> ReverseArray(List<int> arr, int k)
    {
        // Проверяем, что k находится в пределах массива
        if (k < 0 || k >= arr.Count)
        {
            Console.WriteLine("k должно быть в пределах от 0 до " + (arr.Count - 1));
            return arr;
        }

        // Разделяем массив на две части
        List<int> part1 = arr.GetRange(0, k); // элементы до k-го
        List<int> part2 = arr.GetRange(k, arr.Count - k); // элементы от k-го и далее

        // Разворачиваем обе части
        part1.Reverse();
        part2.Reverse();

        // Объединяем обратно
        part1.AddRange(part2);
        return part1;
    }
}

