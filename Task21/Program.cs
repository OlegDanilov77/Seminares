// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату Х: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату Х: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z: ");
double zb = Convert.ToDouble(Console.ReadLine());

double Distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double xRas = xa - xb;
    double yRas = ya - yb;
    double zRas = za - zb;
    double res = Math.Sqrt(xRas * xRas + yRas * yRas + zRas * zRas);
    return res;
}

double result = Math.Round((Distance(xa, ya, za, xb, yb, zb)), 2, MidpointRounding.ToZero);
Console.WriteLine($"A({xa},{ya},{za}), B({xb},{yb},{zb}) -> {result}");
