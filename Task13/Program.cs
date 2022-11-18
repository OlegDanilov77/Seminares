// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет. Выполнить с помощью числовых 
// операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = -number;

if (number < 100)
{
    Console.WriteLine("У введенного числа третьей цифры нет");
    goto End;
}

double numRazrjad = Math.Pow(10, Convert.ToString(number).Length - 3);
// пришлось делать дубль поскольку возведение в степень не работает с инт
int result = (number / Convert.ToInt32(numRazrjad)) % 10;

Console.WriteLine($"Третья цифра введенного числа: {result}");

End:;

// Выглядит сложно, зато работает с числами до 10 знаков