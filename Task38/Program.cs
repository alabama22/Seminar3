// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
    }
    return array;
}

void PrintArrayDouble(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

double GetMaxNum(double[] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        maxNum = Math.Max(maxNum, array[i]);
    }
    return maxNum;
}

double GetMinNum(double[] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        minNum = Math.Min(minNum, array[i]);
    }
    return minNum;
}

double GetDifMinMax(double[] array)
{
    double maxNum = GetMaxNum(array);
    double minNum = GetMinNum(array);
    double result = Math.Round((maxNum - minNum), 1);
    return result;
}

double[] array = CreateArrayRndDouble(4, 1, 80);
PrintArrayDouble(array);
double maxNum = GetMaxNum(array);
double minNum = GetMinNum(array);
double dif = GetDifMinMax(array);
Console.WriteLine($"-> {dif}");
