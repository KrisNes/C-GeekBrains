// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int dayoftheweek(int num)
{
    if (num >= 1 && num <= 5 ) 
    {
        Console.WriteLine("Это будний день");
    }
    else if (num >= 6 && num <=7)
    {
        Console.WriteLine("Это выходной день");
    }
    else Console.WriteLine("Такого дня недели нет");
    return num;
}
Console.WriteLine("Введите число дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
dayoftheweek(num);

