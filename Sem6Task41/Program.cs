//№41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int[] ReadData(string? nums)
{
    Console.WriteLine(nums);
    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    return arr;
}

int CountNums(int[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if(arr[i]>0)
        {
            count++;
        }
    } 
    return count;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] arr = ReadData("Введите элементы(через пробел): ");
int count = CountNums(arr);
PrintResult(" " + count);
