// Считываем данные с консоли
string? inputLine = Console.ReadLine();

// Проверяем, чтобы данные были не пустые
if(inputLine !=null)

// Изменяем строку в целое число
{
    int InputNumber = int.Parse (inputLine);
// Счетчик цикла стартует с 2, т.к. нужны четные числа
    int index = 2;

    string outLine = string.Empty;

// Цикл до (введенного числа +1), чтоб, если введенное число четное, то оно попадает в строку
    while(index < InputNumber +1)
    {
// Приписываем четные числа
        outLine = outLine + index + ',';
        index = index+2;
    } 
    outLine=outLine.TrimEnd(',');;

    Console.WriteLine(outLine);  
} 

