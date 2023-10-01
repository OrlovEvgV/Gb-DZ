//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int[,] Fill2DArray(int countRow, int countColumn)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rnd.Next(1, 9);
        }
    }

    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumEl(int[,] array)
{
    int[] sumArr = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumArr[i] += array[i, j];
        }
        
    }
    int minSum = sumArr[0];
    int minRow = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (sumArr[i] < minSum)
        {
            minSum = sumArr[i];
            minRow = i + 1;
        }
    }
    return minRow;
}

int numberOfRows = ReadData("введите количество строк ");
int numberOfColumns = ReadData("введите количество столбцов ");
int[,] arr2D = Fill2DArray(numberOfRows, numberOfColumns);
Print2DArray(arr2D);
int row = MinSumEl(arr2D);
Console.WriteLine($"Наименьшая сумма в {row} строке.");