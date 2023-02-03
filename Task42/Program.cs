// Задача 42: Напишите программу, 
//которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

string DecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }

    return result;
}

Console.Write("Введите десятичное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

string decToBin = DecToBin(number1);

Console.WriteLine(decToBin);