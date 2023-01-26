// Задача 28: Напишите программу, 
// 2. которая принимает на вход число N и 
// 3. выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number}->{sumNumbers}");
}
else
    Console.WriteLine(" Введено не корректное значение");


int SumNumbers(int num)
{
    int sum = 1;
    for (int i = 1; i <= num; i++)
    {
        sum *= i; //sum+=i

    }
    return sum;
}


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// void Equals(int num)
// {
//     int sum = 0;
//     int i=1;
//     while (i <= num)
//     {
//         Console.WriteLine($"{sum * sum}");
//         sum+=i;
//     }
// }
// Equals(number);