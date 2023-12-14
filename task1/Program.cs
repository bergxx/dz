// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = { 1, 12, 35, 42, 51, 53, 72, 75, 97, 100 };

int min = 20;
int max = 90;

int count = 0;

foreach (int number in array)
{
    if (number >= min && number <= max)
    {
        count++;
    }
}
Console.WriteLine($"количество элементов в диапазоне от {min} до {max}: {count}");