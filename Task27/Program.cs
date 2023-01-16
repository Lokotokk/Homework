/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("число должно быть положительным");
else Console.WriteLine($"{number}->{SumNumbers(number)}");

int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}