// Задача 23
// 1. Напишите программу, которая 
// 2. принимает на вход число (N) и 
// 3. выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Cube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} {count * count * count}");
        count++;
    }
}
Cube(number);
