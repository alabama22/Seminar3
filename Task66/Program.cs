// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(numberM, numberN);
int NaturalNumbers(int numM, int numN)
{
    if (numM > numN) return numN + NaturalNumbers(numN + 1, numM);
    return numM == numN ? numM : numM + NaturalNumbers(numM + 1, numN);
    // return numM>numN? numN:numN+NaturalNumbers(numN,numM+1) ;
}

int numbersNatural = NaturalNumbers(numberM, numberN);
Console.WriteLine(numbersNatural);