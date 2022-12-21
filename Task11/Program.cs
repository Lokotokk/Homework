/*Задача 10: Напишите программу, которая 
принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("введите трехзначное число:   ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 999 & number > 0)
{
    int secondDigit = SecondDigit(number);
    Console.WriteLine($"{number} -> {secondDigit}");
}
else if (number < 0 & number >= -999)
{
    int secondDigit = SecondDigit(number);
    int secondDigit2 = secondDigit * (-1);
    Console.WriteLine($"{number} -> {secondDigit2}");
}
else
{
    Console.WriteLine("чило не является трехзначным");
}
int SecondDigit(int num)
{
    int remainder = num % 100;
    return remainder / 10;
}