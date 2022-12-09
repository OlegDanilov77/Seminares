// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.Clear();
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < numberN)
{
    NaturalMinMax(numberM, numberN);
}
else
{
    NaturalMaxMin(numberM, numberN);
}

void NaturalMinMax(int numMin, int numMax)
{
    if (numMax == numMin - 1) return;
    NaturalMinMax(numMin, numMax - 1);
    Console.Write($"{numMax} ");
}

void NaturalMaxMin(int numMin, int numMax)
{
    if (numMin == numMax - 1) return;
    Console.Write($"{numMin} ");
    NaturalMaxMin(numMin - 1, numMax);
}