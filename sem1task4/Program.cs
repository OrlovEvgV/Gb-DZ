int numA = int.Parse(Console.ReadLine() ?? "0");
int numB = int.Parse(Console.ReadLine() ?? "0");
int numC = int.Parse(Console.ReadLine() ?? "0");
int max = numA;

if (max < numA) max = numA;
if (max < numB) max = numB;
if (max < numC) max = numC;

Console.WriteLine(max);