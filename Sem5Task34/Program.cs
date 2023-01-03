
int[] array = GenArray(123, 100, 999);
int result=0;
PrintArray(array);
for (int i=0;i<array.Length;i++) {
    if (isEver(array[i])) {
        result++;
    }
}

PrintData("Количество четных чисел в массиве", result);

//заполнение массива
int[] GenArray(int len, int minValue, int maxValue)
{
        
    int[] outArray = new int[len];
    
    for (int i = 0; i < len; i++)
    {
        outArray[i] = new Random().Next(minValue, maxValue);
    }
    return outArray;
}


void PrintData(string res, int value)
{
    Console.WriteLine();
    Console.WriteLine(res + value);
}

void PrintArray(int[] array)
{
    Console.WriteLine("содержимое массива");
    if (array!=null && array.Length>0) {
        for(int i=0;i<array.Length;i++)
        PrintData("элемент "+ i +"=", array[i]);
    }
}


Boolean isEver(int value) {
    return value %2==0;
}


