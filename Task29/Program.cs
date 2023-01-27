// Задача 29: Напишите программу, 
// 1. которая задаёт массив из 8 элементов и 
// 2. выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] GenerateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    //Console.Write("[");
    for (int i = 0; i <= array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    //Console.WriteLine("]");
}

int[] arr = GenerateArray(9, 1, 100);
PrintArray(arr);
System.Console.Write(" -> [");
PrintArray(arr);
System.Console.WriteLine("]");