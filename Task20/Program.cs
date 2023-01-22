// Math.Pow(2, 10);
// Math.Sqrt(5);
// double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);

// Задача 20: Напишите программу, 
// 1.которая принимает на вход координаты двух точек и
// 2.находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x1: "); int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1: "); int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.Write("x2: "); int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2: "); int y2 = Convert.ToInt32(Console.ReadLine());

// int double d = 5.09997623455;
// double dRuynd = Math.Round(d, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(dRuynd);
double distance = Distance(x1, y1, x2, y2);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"{distanceRound}");
double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
}