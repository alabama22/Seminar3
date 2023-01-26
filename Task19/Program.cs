// Задача 19
// 1.Напишите программу, 
// 2.которая принимает на вход пятизначное число и 
// 3.проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int pal, num, pal2 = 0;
Console.Write("Введите пятизначное число: ");
string s = Console.ReadLine();

if (int.TryParse(s, out pal))
{
    num = pal;
    while (num > 0)
    {
        pal2 *= 10;
        pal2 += num % 10;
        num /= 10;
    }
    if (pal == pal2) Console.WriteLine("да");
    else Console.WriteLine("нет");
}


// {
//     Console.WriteLine("Введите пятизначое число: ");
//     int number = Convert.ToInt32(Console.Read());
//     palindrome = number;
//     int result, palindrome, num, reverse = 0;

//     for (int i = 1; palindrome != 0; i++)
//     {
//         num = palindrome % 10;
//         palindrome = palindrome / 10;
//         reverse = num + (reverse * 10);
//     }
//     return result;

//     if (reverse == result)
//         Console.WriteLine(result ? "да" : "нет");
//     else
//         Console.WriteLine("Введено не пятизначное число!");
// }
// 23432 -> да

// int pal, num, pal2 = 0;
// Console.Write("Введите пятизначное число: ");
// string s =Console.ReadLine();
// if (num <10000 && num>99000)
// Console.WriteLine("введены не корректные данные!");

// if (int.TryParse(s, out pal))
// {
//     num = pal;
//     while (num > 0)
//     {
//         pal2 *= 10;
//         pal2 += num % 10;
//         num /= 10;
//     }
//     if (pal == pal2) Console.WriteLine("да");
//     else Console.WriteLine("нет");
// }