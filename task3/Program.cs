// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = { 41.14, 82.71, 4.56, 21.18, 15.97, 88.32, 35.27, 49.32, 7.12, 12.52 };

double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
        {
            max = array[i];
        }

    if (array[i] < min)
        {
            min = array[i];
        }
}
double sum = max - min;
Console.WriteLine($"максимальный элемент: {max}");
Console.WriteLine($"минимальный элемент: {min}");
Console.WriteLine($"разница между максимальным и минимальным элементами: {sum}");