﻿// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// Например: 
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int max = a;
if (b > max)
{
    max = b;
}
if (c > max)
{
    max = c;
}
Console.WriteLine("Наибольшее из введённых чисел -> " + max);