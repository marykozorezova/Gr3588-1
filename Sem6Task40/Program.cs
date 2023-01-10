int A = ReadData("Enter first number: ");
int B = ReadData("Enter second number: ");
int C = ReadData("Enter third number: ");
TriangleTest(A,B,C);
PrintData ("Result: " + TriangleTest(A,B,C));


int ReadData(string msg)
{
Console.WriteLine(msg);
return int.Parse(Console.ReadLine() ?? "0");
}


void PrintData(string res)
{
Console.WriteLine(res);
}

bool TriangleTest (int a, int b, int c)
{
return ((a+b<c)&& (a+c<b)&& (b+c>a));
}