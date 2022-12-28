﻿/*Задача 21
Напишите программу, которая 
принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты первой точки X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки У: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки У: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, ya, za, xb, yb, zb), 2, MidpointRounding.ToZero);
Console.WriteLine(ourDistance);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}