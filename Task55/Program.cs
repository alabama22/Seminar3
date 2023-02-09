// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReverseRowsColumns(int[,] matrix)
{
    int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            tempMatrix[j, i] = matrix[i, j];
            matrix[i, j] = tmp;
        }
    }
    return tempMatrix;
}

int[,] matr = CreateMatrixRndInt(3, 3, 1, 10);
PrintMatrix(matr);
Console.WriteLine();

if (matr.GetLength(0) == matr.GetLength(1))
{
    int[,] matrixReplace = ReverseRowsColumns(matr);
    PrintMatrix(matrixReplace);
}
else Console.WriteLine("размеры строк и столбцов отличаются!");
