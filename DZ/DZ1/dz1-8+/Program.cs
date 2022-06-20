/*
ДЗ/1-8+: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


void EvenNumbers (int arg)
{
    if (arg > 0)
    {
        for (int i = 1; i <= arg; i++)
        {

            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i != arg & i != arg - 1)
                {
                    Console.Write(", ");
                }
            }

        }
    }
    else if (arg < 0)
    {
        for (int i = -1; i >= arg; i--)
        {

            if (i % 2 == 0)
            {
                Console.Write(i);
                if (i != arg & i != arg + 1)
                {
                    Console.Write(", ");
                }
            }

        }

    }
    else
    {
        Console.Write(0);
    }
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Найдены следующие чётные числа: ");
EvenNumbers(number);
Console.WriteLine();
