// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int DegreeNumber(int number, int degree)
{
    if (degree == 0) return 1;
    return DegreeNumber(number, degree - 1) * number;
}

System.Console.WriteLine(DegreeNumber(numberA, numberB));