// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число А: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число В: ");
double numB = Convert.ToDouble(Console.ReadLine());

double Qube(double num1, double num2)
{
    double res = 1;
    for (int i = 0; i < num2; i++)
    {
        res = res * num1;
    }
    return res;
}

double qube = Qube(numA, numB);
Console.Write($"Возведение {numA} в степень {numB} = {qube}");