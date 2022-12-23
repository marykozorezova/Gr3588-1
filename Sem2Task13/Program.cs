int number = int.Parse(Console.ReadLine() ?? "0");
string numString=number.ToString();
if (numString.Length >=3)
{
    
    Console.WriteLine(numString.Substring(1,1));
}
else
{
    Console.WriteLine("Третьей цифры нет в числе");
}
