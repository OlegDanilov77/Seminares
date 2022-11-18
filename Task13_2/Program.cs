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

int count = 1000;

while (number / count != 0)
{
    count = count * 10;
}

int result = (number / (count / 1000)) % 10;
Console.WriteLine($"Третья цифра введенного числа: {result}");
End:;