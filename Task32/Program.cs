// Задача 32: 
// 1. Напишите программу 
// 2. замена элементов массива: 
// 3. положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
    Console.WriteLine("]");
}
// инверсия массива
void ReverseArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i]; Console.Write($"{-array[i]}, ");
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayRndInt(4, -9, 9);
ReverseArray(arr);
PrintArray(arr);


