
double Fib(double n)
{
    if (n == 1) return 1;
    else return n * Fib(n - 1);
}

for (int i = 1; i < 500; i++)
{
    Console.WriteLine(Fib(i));
}

