int [] numbers = 

PrintData("Result: " + CountPosNum(numbers));

//Метод, считывающий данные, введенные пользователем
int[] ReadData()
{
    
}

//Метод, выводящий на печать данные пользователю
void PrintData(string res)
{
    Console.WriteLine(res);
}

int CountPosNum(int[] nums)
{
   var result=0;
   for (int i = 0; i < nums.Length; i++)
   {
     if (nums[i]>0) result++;
   } 
    return result;
}