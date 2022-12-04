// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Clear();
System.Console.WriteLine("Введите число вводимых элементов: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] NewArray(int num)
{
    int[] arr = new int[num];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int Schet(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) res++; 
    }
    return res;
}

Console.WriteLine($"Число значений больше 0 равно: {Schet(NewArray(number))}");