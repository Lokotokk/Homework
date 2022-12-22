/*Задача 13: Напишите программу, которая 
выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/


Console.WriteLine("введите число:   ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 99 & number >= -99)
{
    Console.WriteLine($"{number}-> третьей цифры нет");
}
else if (number >= 100)
{
    int thirdDigit = ThirdDigit(number);
    Console.WriteLine($"{number} -> {thirdDigit}");
}
else if (number <= -100)
{
    int thirdDigit = ThirdDigit(number);
    int thirdDigit2 = thirdDigit * -1;
    Console.WriteLine($"{number}-> {thirdDigit2}");
}



int ThirdDigit(int num)
{
    while (num >= 999 | num <= -999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}