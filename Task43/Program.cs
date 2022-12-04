// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine("Введите число b1: ");
double numB1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1: ");
double numK1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2: ");
double numB2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2: ");
double numK2 = Convert.ToDouble(Console.ReadLine());

double FindX(double k1, double b1, double k2, double b2)
{
    double numX = (b2 - b1) / (k1 - k2);
    return numX;
}

double FindY(double x, double b2, double k2)
{
    double numY = k2 * x + b2;
    return numY;
}

double numberX = FindX(numK1, numB1, numK2, numB2);
double numberY = FindY(numberX, numB2, numK2);

Console.WriteLine($"Точка пересечения прямых ({Math.Round(numberX,1)}; {Math.Round(numberY,1)})");