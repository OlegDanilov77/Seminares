// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[8];

Random rnd = new Random();

void Init(int maxValue)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(0, maxValue);
    }
}

void Print();
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array [i]}, ");
    }
    
}

Init(number);