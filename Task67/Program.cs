// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.WriteLine("Введите число M: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = SumNum(number);
Console.WriteLine($"{sum}");

int SumNum(int num)
{
    {
        int sum = 0;
        if (num % 10 == 0) return sum;
        sum = sum + num % 10 + SumNum(num / 10);
        return sum;

    }
}