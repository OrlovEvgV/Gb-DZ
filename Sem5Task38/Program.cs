double[] GenArray(int length, int lowBorder, int highBorder)
{
    double[] arr = new double[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1) + random.NextDouble();
    }
    return arr;
}

double MinMax(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]<min)
        {
            min = arr[i];
        }
        if(arr[i]>max)
        {
            max = arr[i];
        }
    }
    double res = max - min;
    return res;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

double[] arr = GenArray(20, 0, 99);
double res = MinMax(arr);
PrintResult("" + res);