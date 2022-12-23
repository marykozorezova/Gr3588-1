//на основании 2х введенных чисел , выводит что больше
Console.WriteLine("на основании 2х введенных чисел , выводит что больше");
Console.WriteLine("Введите первое число:");
string? firstInput = Console.ReadLine();
if (String.IsNullOrWhiteSpace(firstInput)) {
    Console.WriteLine("недопустимое значение числа");
    return;
}
Console.WriteLine("Введите следующее число:");
string? secondInput = Console.ReadLine();
if (String.IsNullOrWhiteSpace(secondInput)) {
    Console.WriteLine("недопустимое значение числа");
    return;
}

{
    int num1 = int.Parse(firstInput);
    int num2 = int.Parse(secondInput);


     if(num1>num2)
    {
        Console.WriteLine("число {0} больще числа {1}",num1,num2);
    }

    else if (num1==num2) {
        Console.WriteLine("числа равны");

    }
    

    else
    {
        Console.WriteLine("число {0} больще числа {1}",num2,num1);
    }
}
