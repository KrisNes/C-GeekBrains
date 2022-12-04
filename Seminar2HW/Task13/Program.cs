// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


int third_num(int num)
{
    if (num<100)Console.Write("Отсутствует третье число в веденном числе :  ");
    if (num>100 && num<1000) num = num % 10;
    if (num > 1000 && num < 9999) num = num/10 % 10;
    if (num > 10000 && num < 99999) num = num/100 % 10;
    if (num > 99999) Console.Write("Неверно заданное число. Введите число заново.");
    int num1 = num;
    return num1;
}
Console.WriteLine("Ввведите любое целое число(но не более 5 знаков): ");
int num = Convert.ToInt32(Console.ReadLine());

int result = third_num(num);
Console.WriteLine(result);
