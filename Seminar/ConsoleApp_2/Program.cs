﻿Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b * b == a)
{
    Console.WriteLine("Число " + a + " является квадратом числа " + b);
}
else
{
    Console.WriteLine("Число " + a + " не является квадратом числа " + b);
}
