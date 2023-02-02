// Задача 36: 
// 1. Задайте одномерный массив, 
// 2. заполненный случайными числами. 
// 3. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int ArrayOddIndexSum(int []array)
{
    int arr = array[1] + array[array.Length - 1];
    int sum=0;
    for (int i = 2; i < array.Length; i+=2)
    {
         if (array[i]>sum) sum=+array[i];
    }
    return arr;
}

int[] arr = CreateArrayRndInt(4, -9, 99);
PrintArray(arr);
int indexSum=ArrayOddIndexSum(arr);
Console.Write("->");
Console.WriteLine(indexSum);