﻿// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double ColumnsValueSum(int[,] matrix)
{
    double sum = default;
    double arithmeticMean = default;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j < matrix.GetLength(1))
        {
            sum = matrix[0, j] + matrix[1, j] + matrix[2, j];
            arithmeticMean = Math.Round(sum / matrix.GetLength(0), 1); Console.Write($" {arithmeticMean}; ");
        }
    }
    return arithmeticMean;
}
int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);

Console.WriteLine();
double columnSum = ColumnsValueSum(matr);