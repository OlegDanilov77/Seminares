// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int number = new Random().Next(10,100);

int MaxDigit(int num)
{
        int first = num / 10;
        int second = num % 10;
        if (first > second) return first;
        return second;
}

int max = MaxDigit(number);
Console.WriteLine(number);
Console.WriteLine(max);
