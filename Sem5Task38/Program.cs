var array = genArray();

var MinValue=getMinValue(array);
var MaxValue=getMaxValue(array);

Console.WriteLine("The diff between Max {0} and Min {1} is -> {2}",MaxValue,MinValue,(MaxValue-MinValue));

double getMaxValue(double[] arrayOfDouble)
{
    //throw new NotImplementedException();
    return arrayOfDouble.Max();
}

double getMinValue(double[] arrayOfDouble)
{
    //throw new NotImplementedException();
    return arrayOfDouble.Min();
}

double[] genArray()
{
    var array=new Double[10];
    var randomOfDouble= new Random();
    var randomOfInts=new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= randomOfInts.Next(0,99)+randomOfDouble.NextDouble();
    }
    return array;
}
