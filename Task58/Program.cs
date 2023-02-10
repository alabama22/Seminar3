// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}  ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] MatrixMultipleSum(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine(" Умножение не возможно! Количество столбцов матриц не совпадает");
    }
    int[,] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {

        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix3[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrix3;
}

int[,] matr = CreateMatrixRndInt(2, 2, 1, 5);
PrintMatrix(matr);

Console.WriteLine();

int[,] array2D = CreateMatrixRndInt(2, 2, 2, 6);
PrintMatrix(array2D);

Console.WriteLine();

int[,] matr3 = MatrixMultipleSum(matr, array2D);
Console.WriteLine("результирующая матрица : ");
Console.WriteLine();
PrintMatrix(matr3);