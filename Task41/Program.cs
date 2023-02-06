// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество вводимых чисел : ");

int elementsCount = int.Parse(Console.ReadLine());

int[] array = new int[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите число №{i + 1}:\t");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    Console.Write(',');
}
Console.Write("->");

int sum = default;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine(sum);












// int number = int.TryParse((value, StringSplitOptions(',')));


// //PrintArray(numbers);

// int sum = 0;
// for (int i = 0; i < numbers; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();


// int[] CreateNumber(int[] input)
// {
//     int array = new int[input.Length];
//     for (int i = 0; i < input.Length; i++)
//     {
//         array[i] = input[i];
//     }
//     return array;
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] arr = CreateNumber(numbers);
// PrintArray(arr);


// System.Console.WriteLine($"{numbers} {sum}");
