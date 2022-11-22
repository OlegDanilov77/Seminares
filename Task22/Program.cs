Console.Clear();
Console.WriteLine("Введите число N");
int num = Convert.ToInt32(Console.ReadLine());

void Square (int number)
{
   for (int i = 1; i <= number; i++)
   {
        Console.WriteLine($"{i} и его квадрат {i*i}");
   }
}

Square(num);