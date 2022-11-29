// Напишите программу, которая 
// 1. на вход принимает число (N),
// 2. а на выходе показывает все чётные числа от 1 до N.

// Например: 
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2;

if(a > 1)
{
    while(b <= a)
    {
        Console.Write(b + " ");
        b = b + 2;
    }
}
Console.WriteLine();


