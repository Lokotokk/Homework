/*Задача 19.Напишите программу, которая 
принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99999 || number < 10000) Console.WriteLine("число не является пятизначным");
else
{
    bool fivedigitnumber = FiveDigitNumber(number);
    Console.WriteLine(FiveDigitNumber(number) ? "-> да" : "-> нет");
}
bool FiveDigitNumber(int num)
{
    int remains = num % 10;
    int remains2 = num / 1000 % 10;
    return num / 10000 == remains && num % 100 / 10 == remains2;
}
