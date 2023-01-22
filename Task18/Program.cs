// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine(" Введите номер чертверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Possiblecoor(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x > 0, y < 0";
    if (num == 3) return "x < 0, y < 0";
    return " x < 0, y > 0 ";
}
if (quarter > 4 || quarter < 1)
{
    Console.WriteLine("Введите номер чертверти от 1 до 4: ");
}

else
{
    string possibleCoor = Possiblecoor(quarter);
    Console.WriteLine(possibleCoor);
}
