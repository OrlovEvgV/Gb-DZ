int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numB % numA == 0)
{
    Console.WriteLine("2 кратно второму");
}
else
{
    Console.WriteLine("2 число не кратно первому, остаток от деления" + numB % numA);
}