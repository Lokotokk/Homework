/*Задача 15: Напишите программу, которая 
принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("введите цифру, обозначающую день недели:   ");
int daynumber = Convert.ToInt32(Console.ReadLine());
if (daynumber > 7 | daynumber < 1)
{
    Console.WriteLine("нет такого дня недели");
}
else
{
    Console.WriteLine(Weekend(daynumber) ? "выходной" : "нет");
}


bool Weekend(int daynum)
{
    return daynum == 6 || daynum == 7;
}