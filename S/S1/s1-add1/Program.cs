/*
Напишите программу вычисления модуля числа.
2 -> 2
-3 -> 3
-7 -> 7
*/

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine(num + " -> " + (-num));
}
else
{
    Console.WriteLine(num + " -> " + num);
}
