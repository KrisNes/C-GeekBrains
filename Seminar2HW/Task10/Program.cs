// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа. 

// Например: 
// 456 -> 5
// 782 -> 8
// 918 -> 1

int midlenum(int num)
{
    int firstDigit = num / 100;
    int lastDigit = num % 10;
    int result = (num - (firstDigit * 100) - lastDigit)/ 10;
    return result;
}

Console.WriteLine("Ввведите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int result = midlenum(num);
Console.WriteLine(result);
