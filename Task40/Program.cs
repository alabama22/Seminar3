// Задача 40: Напишите программу, 
//которая принимает на вход три числа и 
//проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTringle(int num1, int num2, int num3)
{
    return num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2);
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

bool result = CheckTringle(number1, number2, number3);
Console.WriteLine(result ? "да" : "нет");