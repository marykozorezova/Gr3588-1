    int[] array = GenArray(10,-9,9);
    Print1Arr(array);
    int[] newArray = InverseArr(array);
    Print1Arr(newArray);
    

    int[] GenArray(int len, int minValue, int maxValue)
    {
        Random rnd = new Random();
        int[] arr = new int[len];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(minValue, maxValue + 1);
        }
        return arr;
    }

  
    

    // Печать одномерного массива
    void Print1Arr(int[] arr)
    {
        for (int i = 0; i < arr.Length -1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Length - 1]);
    
    }

    int[] InverseArr(int[] arr)
    {
        int[] outArr = new int[arr.Length];
        for(int i=0;i<arr.Length;i++)
        {
            outArr[i]=arr[i]*(-1);
        }
        return outArr;
    }

