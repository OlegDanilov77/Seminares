// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int[,] array = NewArray(4, 5);
PrintArray(array);
Console.WriteLine();
SortArr(array);
PrintArray(array);

int[,] SortArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        SortArrayString(arr, i);
    }
    return arr;
}

int[,] SortArrayString(int[,] arr2, int str)
{
    int arrlength = arr2.GetLength(1);
    int temp = 0;
    for (int i = 0; i < arrlength - 1; i++)
    {
        for (int j = i + 1; j < arrlength; j++)
        {
            if (arr2[str, j] > arr2[str, i])
            {
                temp = arr2[str, i];
                arr2[str, i] = arr2[str, j];
                arr2[str, j] = temp;
            }
        }
    }
    return arr2;
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