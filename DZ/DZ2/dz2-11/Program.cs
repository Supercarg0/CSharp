/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randNum = new Random().Next(100, 1000);
int num1 = (randNum / 100) * 10;
int num2 = randNum % 10;
int num3 = num1 + num2;
Console.WriteLine($"{randNum} -> {num3}");
