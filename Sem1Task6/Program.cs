string? inputLine = Console.ReadLine();

if (inputLine != null)

{
    int inputNumber=int.Parse(inputLine);
    int inputNumber1=inputNumber%2;

    if (inputNumber1 == 0)
    {
        Console.WriteLine("четное");
    }
    else
    {
        Console.WriteLine("нечетное");
    }
    
}
