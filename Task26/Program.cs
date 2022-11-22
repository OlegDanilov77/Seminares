// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

int NumberDigits(int num)
{
    int result = default;
    int count = 1;
    while ((num / count) > 0)
    {
        count = count * 10;
        result++;
    }
    return result == 0 ? 1: result;
}

int res = NumberDigits(number);
System.Console.WriteLine($"Число цифр равно {res}");
