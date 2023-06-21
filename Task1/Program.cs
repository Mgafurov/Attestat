﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат: " + GetNumbers(N));
    }

    static string GetNumbers(int num)
    {
        if (num == 1)
        {
            return "1";
        }
        else
        {
            return num + ", " + GetNumbers(num - 1);
        }
    }
}
