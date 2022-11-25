// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да
System.Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 10000;
int num2 = (num / 1000) % 10;
int num4 = (num % 100) / 10;
int num5 = num % 10;
    
if (num1 == num5 && num2 == num4) 
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}