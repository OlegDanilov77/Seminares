// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

int NumberDigits(int num)
{
    int result = default;
    while ((num / 10) != 0)
    {
        result = result + (num % 10);
        num = num / 10;
    }
    result = result + (num % 10);
    return result;
}

int res = NumberDigits(number);
System.Console.WriteLine($"Сумма цифр равна {res}");