// Задача 25: Напишите цикл, 
// 1. который принимает на вход два числа (A и B) и 
// 2. возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

double a = numberA, b = numberB;
double result = Math.Pow(a, b);
Console.WriteLine($"{numberA}, {numberB} ->{result} ");
