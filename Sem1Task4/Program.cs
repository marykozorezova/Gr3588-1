// Счиитываем данные с консоли
string? input1Line = Console.ReadLine();
string? input2Line = Console.ReadLine();
string? input3Line = Console.ReadLine();

// Проверяем, чтобы данные были не пустые
if (input1Line != null && input2Line != null && input3Line != null)

{
    // Измепняем введеные строки в целые числа
    int inputNum1 = int.Parse(input1Line);
    int inputNum2 = int.Parse(input2Line); 
    int inputNum3 = int.Parse(input3Line);
    // Сравниваем 1-е и 2-е число
    if (inputNum1>inputNum2)
    {
         // Если 1-е число больше, сравниваем его с 3-м
        if (inputNum1>inputNum3)
        // 1-е число максомальное
        {
             Console.WriteLine("max"+inputNum1);
        }
        else
        // 3-е максимальное число
        {
            Console.WriteLine("max"+inputNum3);
        }
    }

    else
    {
        // Если 2-е больше, сравниваем его с 3-м
        if (inputNum2>inputNum3)
         //2-е число максимальное
        {
        Console.WriteLine("max"+inputNum2);
        }
        // 3-е число максимальное
        else
        {
        Console.WriteLine("max"+inputNum3);
        }

    }
}    


