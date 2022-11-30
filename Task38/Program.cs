// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Clear();
System.Console.WriteLine("Введите число элементов массива: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] NewDouble(int num)
{
    double[] arr = new double[num];

    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите {i} число массива: ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxDifference(double[] arr)
{
    double maxNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double MinDifference(double[] arr)
{
    double minNumber = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

double[] array = NewDouble(number);
Console.Write("Печатаем массив: ");
PrintArray(array);
double diffMax = MaxDifference(array);
double diffMin = MinDifference(array);
double result = diffMax - diffMin;
Console.Write(@$"Разница между максимальным и минимальным элементами массива = {Math.Round(result, 2)}");