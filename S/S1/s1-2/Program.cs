/*
3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/

Console.WriteLine("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine(num + " -> Понедельник");
}
if (num == 2)
{
    Console.WriteLine(num + " -> Вторник");
}
if (num == 3)
{
    Console.WriteLine(num + " -> Среда");
}
if (num == 4)
{
    Console.WriteLine(num + " -> Четверг");
}
if (num == 5)
{
    Console.WriteLine(num + " -> Пятница");
}
if (num == 6)
{
    Console.WriteLine(num + " -> Суббота");
}
if (num == 7)
{
    Console.WriteLine(num + " -> Воскресенье");
}
if (num > 7)
{
    Console.WriteLine("В неделе всего 7 дней!");
}
