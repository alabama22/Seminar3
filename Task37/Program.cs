﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRnd(int size, int min, int max)
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
        if (i < array.Length) Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}
int[] ArrayProdNumFirstLast(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size += 1;

    int[] arrayNew = new int[size];

    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 == 1) arrayNew[arrayNew.Length - 1] = array[array.Length / 2];
    return arrayNew;
}

int[] arr = CreateArrayRnd(5, 1, 9);
PrintArray(arr);
int[] arrNew = ArrayProdNumFirstLast(arr);
Console.Write($"Произведение пар чисел в массиве: ");
PrintArray(arrNew);

