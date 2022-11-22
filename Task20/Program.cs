Console.Clear();
Console.WriteLine("Введите координаты точки А");
Console.Write("Введите координату Х: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double ya = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки B");
Console.Write("Введите координату Х: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y: ");
double yb = Convert.ToDouble(Console.ReadLine());

double Distance (double xa, double ya, double xb, double yb)
{
    double xRas = (xa > xb) ? xRas = xa - xb : xRas = xb - xa;
    double yRas = (ya > yb) ? yRas = ya - yb : yRas = yb - ya;
    double res = Math.Sqrt(xRas*xRas + yRas*yRas);
    return res;
}

double result2 = Math.Round((Distance (xa, ya, xb, yb)), 2, MidpointRounding.ToZero);
Console.WriteLine(result2);
