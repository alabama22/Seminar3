﻿// Задача 50. Напишите программу, которая на вход 
//принимает позиции элемента в двумерном массиве, и 
//возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


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

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.WriteLine("Укажите позиции элементов массива ");
Console.WriteLine("элемент ряда: "); int rowElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("элемент столбца: "); int columnElem = Convert.ToInt32(Console.ReadLine());

string GetElement(int[,] matrix, int row, int column)
{
    if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
    {
        return ($"{matrix[row, column]} ");
    }
    else
    {
        return "такого элемента в массиве нет";
    }
}
string str = GetElement(array2D, rowElem, columnElem);
Console.WriteLine($"{rowElem}, {columnElem} -> {str} ");

