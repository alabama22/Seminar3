// Задача 26: Напишите программу,
// 1. которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите целое положительное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int sumDigit = SumDigit(number);
    Console.WriteLine($"количество цифр в этом числе: {sumDigit}");
}
else Console.Write("Введено не коректное число");

int SumDigit(int num)
{
    int count = 0;

    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}