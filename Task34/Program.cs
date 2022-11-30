// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
System.Console.WriteLine("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] RndArr(int numb)
{
    Random rnd = new Random();
    int[] randomArray = new int[numb];

    for (int i = 0; i < numb; i++)
    {
        randomArray[i] = rnd.Next(100, 1000);
    }
    return randomArray;
}

int Chet(int[] Array)
{
    int chet = 0;
    for (int j = 0; j < Array.Length; j++)
    {
        if (Array[j] % 2 == 0) chet ++;
    }
    return chet;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int [] rndArr = RndArr(number);
PrintArray(rndArr);
Console.Write($"Количество четных элементов = {Chet(rndArr)}");