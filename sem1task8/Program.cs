int num = int.Parse(Console.ReadLine() ?? "0");
int i = 0;

if (num % 2 == 0)
{
}
else
{
    num = num - 1;
}
while (i < num)
    {
        i = i + 2;
        Console.Write(i + " ");
    }