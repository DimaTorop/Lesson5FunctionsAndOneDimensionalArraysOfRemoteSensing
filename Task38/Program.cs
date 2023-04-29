/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

Console.Clear();

#region Ввод данных и определение методов
int[] array = GetArray(8, 1, 100);
int maxNumbrs = GetMaxNumbers(array);
int minNumbrs = GetMinNumbers(array);
int result = GetResultNunbr(array);
PintReport(array, maxNumbrs, minNumbrs, result);
#endregion

#region Вывод результата
void PintReport(int[] array, int maxNumbrs, int minNumbrs, int result)
{
    Console.WriteLine($"[{String.Join(", ", array)}] -> MAX({GetMaxNumbers(array)}) - MIN({GetMinNumbers(array)}) = {GetResultNunbr(array)}");
}
#endregion

#region Заполнение массива рандомными числами
int[] GetArray(int size, int minValue, int maxValue) 
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}
#endregion

#region Определение максимального и минимального числа в массиве
int GetMaxNumbers(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}

int GetMinNumbers(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];

        }
    }
    return min;
}
#endregion

#region Определение разницы между MAX и MIN
int GetResultNunbr(int[] arr)
{
    int res = maxNumbrs - minNumbrs;   
    return res;
}
#endregion