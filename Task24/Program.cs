// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = default;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

if (number > 0)
{
    int sumDigit = SumDigits(number);
    System.Console.WriteLine($"Сумма чисел от 1 до {number} равно {sumDigit}");
}
else System.Console.WriteLine("Требуется ввести натуральное число");