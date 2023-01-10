﻿int[] arr = GenArray(20, 1, 100);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArr = SwapNewArray(arr);
Console.WriteLine("Новый массив перевернутый SwapNewArray методом");
Print1DArr(copyArr);
Console.WriteLine("Исходный массив");
Print1DArr(arr);

int[] copyArrTwo = SwapArray(arr);
Console.WriteLine("Исходный массив");
Print1DArr(arr);
Console.WriteLine("Исходный массив перевернутый SwapArray методом");
Print1DArr(copyArrTwo);

// Метод генерирующий массим
int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] arr = new int[len];
    for (int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

// Метод выводящий массив на печать

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int[] SwapArray(int[] arr)
{
    int bufElement = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        bufElement = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = arr[i];
        arr[i] = bufElement;
    }
    return arr;
}

int[] SwapNewArray(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        outArr[i] = arr[arr.Length - 1 - i];
    }
    return outArr;
}