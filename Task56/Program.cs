// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} ");
            else Console.WriteLine($"{matrix[i, j],1} ");
        }
        //Console.WriteLine("|");
    }
}

void RowSum(int[,] row)
{
    for (int i = 0; i < 4; i++)
    {
        int sum = 0;
        for (int j = 0; j < 4; j++)
        {
            sum += row[i, j];
        }
        //Console.WriteLine($"Сумма элементов ряда {i} : {sum}");
    }
}

int SumMin(int[,] arrSum)
{
    int minSum = arrSum[0, 0];
    int min = default;
    for (int i = 0; i < 4; i++)
    {
        for (int j = 1; j < 4; j++)
        {
            if (minSum > arrSum[i, j])
            {
                minSum = arrSum[i, j];
                min = i;
            }
        }
    }
    Console.WriteLine($"строка с наименьшей суммой элементов: {min}");
}

int[,] arr = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(arr);

RowSum(arr);
SumMin(arr);