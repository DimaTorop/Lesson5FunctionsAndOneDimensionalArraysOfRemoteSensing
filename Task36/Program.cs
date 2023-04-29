/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] array = GetArray(4, -10, 100);
int evenNumbrs = GetEvenNumbers(array);
PrintReport(array, evenNumbrs);

void PrintReport(int[] array, int evenNumbrs)
{
    Console.WriteLine($"[{String.Join(", ", array)}] -> {evenNumbrs}");
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

int GetEvenNumbers(int[] arr)
{
    int quantityEven = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 1)
        {
            quantityEven = quantityEven + arr[i];
        }
    }
    return quantityEven;
}