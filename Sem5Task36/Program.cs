int[] GenArray(int length, int lowBorder, int highBorder)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = new Random().Next(lowBorder, highBorder + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write($"[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + " ]");
    System.Console.WriteLine();
}

int SumElements(int[] array)
{
    int sumEl = 0;
    for(int i = 1; i < array.Length - 1; i= i+2)
    {
        sumEl = sumEl+array[i]; 
    }
    return sumEl;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(50, -100, 999);
int sumEl = SumElements(array);
PrintArray(array);
PrintResult("Сумма нечетных элементов: " + sumEl);


