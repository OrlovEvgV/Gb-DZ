int digit = int.Parse(Console.ReadLine() ?? "0");
int res = (digit/10)%10;
Console.WriteLine(res);