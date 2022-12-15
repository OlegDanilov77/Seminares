// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;

if (numberM < numberN)
{
    Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {NaturalMinMax(numberM, numberN)}");
}
else
{
    Console.WriteLine($"Сумма чисел от {numberM} до {numberN} = {NaturalMaxMin(numberM, numberN)}");
}

int NaturalMinMax(int numMin, int numMax)
{
    if (numMax == numMin - 1) return sum;
    sum = sum + numMin;
    NaturalMinMax(numMin + 1, numMax);    
    return sum;
}

int NaturalMaxMin(int numMin, int numMax)
{
    if (numMin == numMax - 1) return sum;
    sum = sum + numMin;
    NaturalMaxMin(numMin - 1, numMax);
    return sum;
}