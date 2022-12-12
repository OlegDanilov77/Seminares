// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка
Console.Clear();
int[,] array = NewArray(4, 5);
PrintArray(array);
Console.WriteLine($"{MinStr(array)} строка");

int MinStr(int[,] arr)
{
    int sumMin = 0;
    int result = 1;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        if (i == 0) sumMin = sum;
        if (sum < sumMin)
        {
            sumMin = sum;
            result = i + 1;
        }
    }
    return result;
}

int[,] NewArray(int numM, int numN)
{
    int[,] arr = new int[numM, numN];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = (rnd.Next(0, 100));
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
            if (arr[i, j] / 10 == 0) Console.Write($" ");
        }
        Console.WriteLine("]");
    }
}
