﻿/*
4: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Найдены следующие чётные числа: ");
if (number == 0)
{
    Console.Write(number);
}
for (int i = 1; i <= number; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i);
        if (i != number && i != number - 1)
        {
            Console.Write(", ");
        }
    }
}
Console.WriteLine();
