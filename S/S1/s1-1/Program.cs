/*
1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 5; b = 25 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> нет
a = -3 b = 9 -> да
*/

Console.WriteLine("Введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 * num1 == num2)
{
    Console.WriteLine("a = " + num1 + "; " + "b = " + num2 + " -> да");
}
else
{
    Console.WriteLine("a = " + num1 + "; " + "b = " + num2 + " -> нет");
}
