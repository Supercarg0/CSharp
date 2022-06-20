/*
7. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = -num; i <= num; i++)
{
    Console.Write(i);
    if (i != num)
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
        Console.WriteLine();
    }
}
*/

int n;
int current;

Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());

if (n < 0)
{
    n = n * (-1);
}

current = n * (-1);

while (current <= n)
{
    Console.Write(current);
    if (current != n)
    {
        Console.Write(", ");
    }
    current++;
}
Console.WriteLine();