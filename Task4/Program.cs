// Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. выдаёт максимальное из этих чисел.

// Например: 
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите 3 целых числа: ");
var a = Decimal.Parse(Console.ReadLine());
var b = Decimal.Parse(Console.ReadLine());
var c = Decimal.Parse(Console.ReadLine());

int max = a;
if (b > max)
    max = b;
if (c > max)
    max = c;
Console.WriteLine("Наибольшее из введённых чисел -> " + max);