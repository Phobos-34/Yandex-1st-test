using System;
using Yandex_test;

class Program
{
    static void Main()
    {
        int[] arr = { 3, 5, 1, 9, -2, 0 }; //Создаем массив

        var result = Finder.FindTwoSmallestSum(arr);
        Console.WriteLine($"Два числа с наименьшей суммой: {result.Item1} и {result.Item2}");
        Console.WriteLine($"Сумма: {result.Item1 + result.Item2}");
    }
}

//Временная сложность: O(n)