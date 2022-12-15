// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.WriteLine("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Значение функции Аккермана для m={numberM} и n={numberN} равно {Accerman(numberM, numberN)}");

int Accerman(int numM, int numN)
{
    if (numM == 0)
    return numN + 1;
else
    if ((numM != 0) && (numN == 0))
    return Accerman(numM - 1, 1);
else
    return Accerman(numM - 1, Accerman(numM, numN - 1));
}