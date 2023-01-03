int[] array = GenArray(123, -100, 100);
PrintArray(array);

int result = SumOdd(array);
Console.WriteLine();
PrintData("Сумма элементов, стоящих на нечетных позициях", result);

int[] GenArray(int len, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] outArray = new int[len];
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}

int SumOdd(int[] array)
{
    int res = 0;
    int i =1;
    while (i < array.Length)
    {
        res+=array[i];
        i = i+2;
        {
            res++;
        }
    }
    return res;
}