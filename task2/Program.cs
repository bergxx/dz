﻿// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = { 2, 6, 8, 10, 11, 12, 13, 15, 16, 17 };

int count = 0;

foreach (int number in array)
{
    if (number % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"количество четных чисел: {count}");