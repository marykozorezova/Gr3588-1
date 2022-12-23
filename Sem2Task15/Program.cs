internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("введите порядковый номер дня недели");
        int number = int.Parse(Console.ReadLine() ?? "0");
        if (number >= 1 && number <= 7)
        {
            if (number > 5)
            {
                Console.WriteLine("Выходной");
            }
            else
            {
                Console.WriteLine("Рабочий день");
            }
        }
    }
}