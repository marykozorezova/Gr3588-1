int number1 = int.Parse(Console.ReadLine() ?? "0");
int number2 = int.Parse(Console.ReadLine() ?? "0");
if (result ==0)
{
    Console.WriteLine("Второе число делится на первое без остатка");
}
else
{
    Console.WriteLine("Второе число делится не кратно первому. Остаток от деления"+result);
}

