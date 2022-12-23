
int number = int.Parse(Console.ReadLine() ?? "0");
if(number<1000 && number > 99)
{
 
    int result=(number/10)%10;

    Console.WriteLine(result);

}

else
    {
        Console.WriteLine("Введите 3-х значное число");
    }


//Вариант 2 ( универсальный)
/*
int number = int.Parse(Console.ReadLine() ?? "0");
var stringNumber=number.ToString();
if (stringNumber.Length>2) {
    Console.WriteLine(stringNumber.Substring(1,1));
}
*/