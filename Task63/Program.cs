Console.Clear();
Console.WriteLine("Введите строку массива: ");
int number = Convert.ToInt32(Console.ReadLine());

Natural(number);

void Natural(int num)
{
    if (num == 0) return;
    Natural(num - 1);
    Console.Write($"{num} ");
}