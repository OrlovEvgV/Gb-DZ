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
long CalcRes(int firstNum, int secondNum)
{
    long res = 1;
    while (secondNum != 0)
    {
        res = res * firstNum;
        secondNum = secondNum - 1;
    }
    return res;
}

int numA = ReadData("Введите первое число: ");
int numB = ReadData("Введите второе число: ");
long res = CalcRes(numA, numB);
PrintResult("" + res);
