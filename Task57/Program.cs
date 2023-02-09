// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count++] = matrix[i, j];
        }
    }
    return result;
}

string PrintArray(int[] arr)
{
    string str = string.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        str += $"{arr[i]} ";
    }
    return str;
}

void GetSameNum(int[] arr)
{
    int temp = arr[0];
    int count = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (temp == arr[i]) count++;
        else
        {
            Console.WriteLine($"{temp} встречается {count} раз(а) ");
            temp = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"{temp} всречается {count} раз(а) ");
}

    int[,] matr = CreateMatrixRndInt(3, 4, 1, 10);
    PrintMatrix(matr);

    int[] arr = MatrixToArray(matr);
    Array.Sort(arr);

    Console.WriteLine(PrintArray(arr));

    GetSameNum(arr);

