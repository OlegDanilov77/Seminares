// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.
Console.Clear();
System.Console.WriteLine("Введите первую сторону: ");
int lineA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите вторую: ");
int lineB = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите третью сторону: ");
int lineC = Convert.ToInt32(Console.ReadLine());

bool Triangle (int a, int b, int c)
{
    if (((a + b) < c) || ((a + c) < b) || ((c + b) < a)) return true; 
    else return false;
}

bool tri = Triangle(lineA, lineB, lineC);
Console.WriteLine(tri ? "нет" : "да");