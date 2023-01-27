// Задача 27: Напишите программу, которая 
// 1. принимает на вход число и 
// 2. выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);

int SumNumbers(int num)
{
    int sum = 0;
    if (num <= 0) num *= -1;
    for (int i = 1; i != num; i++)
    {
        sum += num % 10; //sum+=i
        num = num / 10;

    }
    return sum;
}

Console.WriteLine($"Сумма цифр в числе {number}-> {sumNumbers}");

