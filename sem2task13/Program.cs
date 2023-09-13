int digit = int.Parse(Console.ReadLine() ?? "0");
int length = digit.ToString().Length;
if (length >= 3)
{
    while (digit > 999)
    {
        digit = digit / 10;
    }
    int res = digit % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("3 цифры нет");
}