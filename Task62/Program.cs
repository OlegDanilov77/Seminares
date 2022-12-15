// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Сделал для общего случая, поскольку это интереснее )

Console.Clear();
Console.WriteLine("Введите количество строк массива: ");
int numString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int numColumn = Convert.ToInt32(Console.ReadLine());

int[,] array = SpiralArray(numString, numColumn);
PrintArray(array);

int[,] SpiralArray(int numberString, int numberColumn)
{
    int[,] arr = new int[numberString, numberColumn];
    int sizeMatrix = numberColumn * numberString;
    int curs = 1;// указатель направления движения 1 вправо, 2 вниз, 3 влево, 4 вверх
    int posCol = 0;// текущая позиция (колонна)
    int posStr = 0;// текущая позиция (строка)
    arr[0, 0] = 1;
    for (int i = 2; i <= sizeMatrix; i++)
    {
        if (curs == 1)
        {
            if (posCol == numberColumn - 1 || arr[posStr, posCol + 1] != 0)
            {
                curs++;
            }
            else
            {
                posCol++;
                arr[posStr, posCol] = i;
            }
        }

        if (curs == 2)
        {
            if (posStr == numberString - 1 || arr[posStr + 1, posCol] != 0)
            {
                curs++;
            }
            else
            {
                posStr++;
                arr[posStr, posCol] = i;
            }
        }

        if (curs == 3)
        {
            if (posCol == 0 || arr[posStr, posCol - 1] != 0)
            {
                curs++;
            }
            else
            {
                posCol--;
                arr[posStr, posCol] = i;
            }
        }

        if (curs == 4)
        {
            if (arr[posStr - 1, posCol] != 0)
            {
                curs = 1;
                i--;
            }
            else
            {
                posStr--;
                arr[posStr, posCol] = i;
            }
        }

    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j < arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]} ");
            else Console.Write($"{arr[i, j]}");
            if (arr[i, j] / 10 == 0) Console.Write($" ");
            if (arr[i, j] / 100 == 0) Console.Write($" ");
        }
        Console.WriteLine();
    }
}