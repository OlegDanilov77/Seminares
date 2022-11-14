// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maximal = number1;

if (number2 > maximal) maximal = number2;
if (number3 > maximal) maximal = number3;

    Console.WriteLine($"Максимальное число: {maximal}");