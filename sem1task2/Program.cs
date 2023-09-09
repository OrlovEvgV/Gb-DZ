int numA = int.Parse(Console.ReadLine() ?? "0"); // ввод числа 1
int numB = int.Parse(Console.ReadLine() ?? "0"); // ввод числа 2
if (numA > numB) // сравнение переменных
{
    int max = numA; // присвоение переменной max, при выполнении условия
    int min = numB; // присвоение переменной min, при выполнении условия
    Console.WriteLine(max + " больше ," + min + " меньше"); //вывод результата
}
else
{
    int max = numB; // присвоение переменной max, при не выполнении условия
    int min = numA; // присвоение переменной max, при не выполнении условия
    Console.WriteLine(max + " больше ," + min + " меньше"); //вывод результата
}
