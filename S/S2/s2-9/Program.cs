/*
9.Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
78 -> 8 
12-> 2 
85 -> 8
*/

int randNum = new Random().Next(10,100);
int num1 = randNum / 10;
int num2 = randNum % 10;

if (num1 > num2)
{
    Console.WriteLine($"{randNum} -> {num1}");
}
else
{
    Console.WriteLine($"{randNum} -> {num2}");
}

