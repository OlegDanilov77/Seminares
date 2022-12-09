// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] array = NewArray(3, 4);
PrintArray(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write($"{MiddleColumn(array, i)}; ");
}

double MiddleColumn(int[,] arr, int numColumn)
{
    double sumColumn = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sumColumn = sumColumn + arr[i, numColumn];
    }
    return Math.Round((sumColumn / arr.GetLength(0)), 1);
}

int[,] NewArray(int numM, int numN)
{
    int[,] arr = new int[numM, numN];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (rnd.Next(0, 10));
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
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