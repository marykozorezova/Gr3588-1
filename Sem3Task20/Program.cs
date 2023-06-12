int x1 = ReadData ("Введите координату X1");
int y1 = ReadData ("Введите координату Y1");
int x2 = ReadData ("Введите координату X2");
int y2 = ReadData ("Введите координату Y2");


//Метод читает данные от пользователя
int ReadData (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод находит расстояние между точками на плоскости
double CalculateLenght(int x1, int y1, int x2, int y2);
{
    double res = 0;
    res = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    return res;
}

// Метод выводит данные пользователю
void PrintData(string msg, double res);
{
    Console.WriteLine(msg + res);
}


PrintData("Расстояние между точками равно ", CalculateLenght(x1,y1,x2,y2));
