/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int res = (num % 100);
    res = (res / 10);
    Console.WriteLine($"{num} -> {res}");
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести трехзначное число!");
}
