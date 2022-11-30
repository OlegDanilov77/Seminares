// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
System.Console.WriteLine("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] RndArr(int numb)
{
    Random rnd = new Random();
    int[] randomArray = new int[numb];

    for (int i = 0; i < numb; i++)
    {
        randomArray[i] = rnd.Next(0, 100);
    }
    return randomArray;
}

int NeChetSum(int[] Array)
{
    int sum = 0;
    for (int j = 0; j < Array.Length; j++)
    {
        if (j % 2 != 0)  sum = sum + Array[j];
    }
    return sum;
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
Console.Write($"Сумма элементов на нечетных местах = {NeChetSum(rndArr)}");