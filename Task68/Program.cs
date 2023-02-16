﻿// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите два числа: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int numberN = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(numberM, numberN);
int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

Console.Write("-> A(m,n) = ");
int functionAkkerman = AkkermanFunction(numberM, numberN);
Console.WriteLine(functionAkkerman);
