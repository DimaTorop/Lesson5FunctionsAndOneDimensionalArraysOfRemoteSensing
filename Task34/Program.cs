/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

Console.Clear();

int[] array = GetArray(6, 100, 300);
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
        if (arr[i] % 2 == 0)
        {
            quantityEven = quantityEven + 1;
        }
    }
    return quantityEven;
}