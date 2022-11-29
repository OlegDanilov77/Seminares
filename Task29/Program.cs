// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
System.Console.WriteLine("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите минимальное случайное число: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите максимальное случайное число: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];

Random rnd = new Random();

void InitArray(int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = rnd.Next(min, max);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array [i]} ");
    }
    
}

InitArray(minValue, maxValue);
PrintArray();