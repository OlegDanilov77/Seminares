﻿Console.Clear();
Console.Write("Введите номер четверти: ");
int n = Convert.ToInt32(Console.ReadLine());

string Quarter(int nc)
{
    if (nc == 1) return "x > 0 и y > 0";
    if (nc == 2) return "x < 0 и y < 0";
    if (nc == 3) return "x < 0 и y > 0";
    if (nc == 4) return "x > 0 и y < 0";
    return "Введены некорректные данные";
}

string quarter = Quarter(n);
Console.WriteLine(quarter);