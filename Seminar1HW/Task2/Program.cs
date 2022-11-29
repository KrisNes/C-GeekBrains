// Напишите программу, которая 
// 1. на вход принимает два числа и 
// 2. ввыдаёт, какое число большее, а какое меньшее.

// Например: 
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите 2 целых числа: ");
// var a = Decimal.Parse(Console.ReadLine());
// var b = Decimal.Parse(Console.ReadLine());
// Console.WriteLine("Наибольшее число: ");
// if (a > b)
// Console.WriteLine(a);
// else 
// Console.WriteLine(b);
// Console.WriteLine("Наименьшее число: ");
// if (a < b)
// Console.WriteLine(a);
// else 
// Console.WriteLine(b);

Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (a > b)
{
    Console.WriteLine("Наибольшее число " + a);
    Console.WriteLine("Наименьшее число " + b);
}
else
{
    Console.WriteLine("Наибольшее число " + b);
    Console.WriteLine("Наименьшее число "  + a);
}