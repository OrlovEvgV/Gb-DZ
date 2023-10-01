int[,] CreateMatrix(int m, int n, int k)
{
    int[,] matrix = new int[m, n];
    int count = 0;

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            count = count + k;
            matrix[i, j] = count;
        }
    }
    return matrix;
}

void Print2DArray(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
}    

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int m = ReadData(" ");
int n = ReadData(" ");
int k = ReadData(" ");
int[,] matrix = CreateMatrix(m, n, k);
Print2DArray(matrix);