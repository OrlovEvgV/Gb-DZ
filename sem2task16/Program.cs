int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);
if (test1) Console.WriteLine("1 квадрат 2");
if (test2) Console.WriteLine("2 квадрат 1");
if (!(test1 || test2))
{
    Console.WriteLine("числа не квадраты друг друга");
}