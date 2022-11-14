// Выводим числа от -N до N
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = -number;
while (count <= number)
{
    Console.Write($"{count} ");
    count++;
}
