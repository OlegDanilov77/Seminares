// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
Console.WriteLine("Введите число строк массива: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива: ");
int numberN = Convert.ToInt32(Console.ReadLine());

double[,] NewDouble(int numM, int numN)
{
    double[,] arr = new double[numM, numN];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Convert.ToDouble(rnd.Next(-100, 100)) / 10;
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

double[,] array = NewDouble(numberM, numberN);
PrintArray(array);