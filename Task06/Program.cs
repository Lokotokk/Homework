/*Задача 6: Напишите программу, которая 
на вход принимает число и 
выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

Console.WriteLine("введите целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int remains = number1 % 2;
if (remains == 0) Console.WriteLine($"число {number1} является четным");
else Console.WriteLine($"число {number1} не является четным");