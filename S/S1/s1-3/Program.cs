/*
Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
*/

int number;
int numLast;

Console.Write("Введите трехзначное число: ");
number = Convert.ToInt32(Console.ReadLine());

numLast = number % 10;
Console.WriteLine($"Последняя цифра: {numLast}");
