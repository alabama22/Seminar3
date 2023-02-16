// Задача 67: Напишите программу, которая будет принимать 
// на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);
int NaturalNumbers(int num)
{
    if (num == 0) return 0;
    return num % 10 + NaturalNumbers(num / 10);
}

int numbersNatural = NaturalNumbers(number);
Console.WriteLine(numbersNatural);