// Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1
// ИЗВИНИТЕ - Добавил защиту от дурака ))
Console.Clear();
Wrong: Console.WriteLine("Введите трехзачное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

if (number < 100 || number > 999)
{
    Console.WriteLine("Введенное число некорректно");
    goto Wrong;
}

int result = (number / 10) % 10;

// если через целочисленное деление:
// int result = (number/10)-((number/100)*10);

Console.WriteLine($"Вторая цифра введенного числа: {result}");