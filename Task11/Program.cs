﻿// Убираем среднюю цифру случайного числа

// int number = new Random().Next(100, 1000);
// Console.WriteLine(number);
// int result = (number / 100) * 10 + (number % 10);
// Console.WriteLine(result);

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 --> {number}");
Console.WriteLine(KillSecondDigit(number));

int KillSecondDigit(int num)
{
    int fitstDigit = num / 100;
    int thirdDigit = num % 10;
    int result = fitstDigit * 10 + thirdDigit;
    return result;
}
