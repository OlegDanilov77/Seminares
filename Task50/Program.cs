// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.Clear();
double[,] array = NewDouble(4, 5);
PrintArray(array);

Console.WriteLine("Введите строку массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец массива: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < 0 ||
    numberM > array.GetLength(0) ||
    numberN < 0 ||
    numberN > array.GetLength(1))
{
    Console.WriteLine("Такого элемента не существует");
}
else
{
    Console.WriteLine($"Значение элемента = {array[numberM, numberN]}");
}

double[,] NewDouble(int numM, int numN)
{
    double[,] arr = new double[numM, numN];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (rnd.Next(-100, 100));
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]}, ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine("]");
    }
}