﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого 
// элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
Console.Clear();
int[,,] matrix = NewMatrix(4, 4, 4);
PrintArray(matrix); // оставил вывод постранично для проверки
PrintArrayString(matrix);

int[,,] NewMatrix(int numRow, int numColumn, int numDepth)
{
    int[,,] arr = new int[numRow, numColumn, numDepth];
    Random rnd = new Random();
    int sizeMatrix = (arr.GetLength(0) + 1) * (arr.GetLength(0) + 1) * (arr.GetLength(0) + 1);
    int[] numberList = new int[sizeMatrix];// создаем список элементов для проверки повторяемости
    int countList = 0;
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
            label: temp = (rnd.Next(10, 100));
                for (int m = 0; m < sizeMatrix; m++)
                {
                    if (temp == numberList[m]) goto label; // проверка на повтор
                }
                numberList[countList] = temp;
                arr[i, j, k] = temp;
                countList++;
            }
        }
    }
    return arr;
}

void PrintArrayString(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(2); k++)
    {
        Console.WriteLine($"Страница {k + 1}");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("[");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j < arr.GetLength(1) - 1)
                    Console.Write($"{arr[i, j, k]}, ");
                else Console.Write($"{arr[i, j, k]}");
            }
            Console.WriteLine("]");
        }
    }
}
