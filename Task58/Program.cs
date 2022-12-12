// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
int[,] matrixA = NewMatrix(4, 4);
int[,] matrixB = NewMatrix(4, 5);
if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Умножение матриц невозможно");
    }
else
    {
    Console.WriteLine("Матрица А:");
    PrintArray(matrixA);
    Console.WriteLine();
    Console.WriteLine("Матрица В:");
    PrintArray(matrixB);
    Console.WriteLine();
    Console.WriteLine("Произведение матриц А и В:");
    PrintArray(MatrixMultip(matrixA, matrixB));
    }

int[,] MatrixMultip(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            matrC[i,j] = 0;
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                 matrC[i,j] += matrA[i,k] * matrB[k,j]; // каджит =)
            }
        }
    }
    return matrC;
}

int[,] NewMatrix(int numM, int numN)
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
            if (arr[i, j] / 10  == 0) Console.Write($" ");
            if (arr[i, j] / 100 == 0) Console.Write($" ");
        }
        Console.WriteLine("]");
    }
}
