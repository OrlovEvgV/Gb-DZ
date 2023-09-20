int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rdn = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rdn.Next(0, 10);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int len = ReadData("Введите длину массива: ");
int[] arr = GenArr(len);
PrintArr(arr);
