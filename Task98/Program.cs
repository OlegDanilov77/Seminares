// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void FillArray(int[] collect)
{
    int lenght = collect.Length;
    int index = 0;
    while (index < lenght)
    {
        collect[index] = new Random().Next(1, 100);
        index++;
    }
}
void Print(int[]collect2)
{
    int lenght2 = collect2.Length;
    int index2 = 0;
    while (index2 < lenght2)
    {
        Console.WriteLine(collect2[index2]);
        index2++;
    }    
}

int[] array = new int[10];
FillArray(array);
Print(array);