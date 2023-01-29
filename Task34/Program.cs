// Задача 34: 
// 1. Задайте массив 
// 2. заполненный случайными положительными трёхзначными числами. 
// 3. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// функция создания массива
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
// функция вывода массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length) Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

int PositiveNum(int[] array)
{

    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) even++;
    }
    return even;
}

int[] arr = CreateArrayRndInt(4, 100, 999);
PrintArray(arr);
int evenNumb = PositiveNum(arr);
Console.WriteLine($"-> {evenNumb}");
