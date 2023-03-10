// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int[] CreateArrayFiB(int num)
{
    int[] array = new int[num];
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.WriteLine($"{array[i]}");
    }
}

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArrayFiB(number1);
Console.Write($"Если N = {number1}");
Console.Write(" -> ");

PrintArray(arr);

