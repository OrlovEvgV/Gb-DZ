int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int sumNumber(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = (num % 10) + res;
        num = num / 10;
    }
    return res;
}

int number = ReadData("Введите число: ");
int res = sumNumber(number);
PrintResult("" + res);