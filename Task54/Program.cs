﻿// Задача 54: 
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine(String.Empty);
DescendingOrderInRows(array2D);
PrintMatrix(array2D);

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine();
    }
}

void DescendingOrderInRows(int[,] matrix)
{
    int temp = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1 - i; j++)
            {
                if (matrix[m, j] < matrix[m, j + 1])
                {
                    temp = matrix[m, j];
                    matrix[m, j] = matrix[m, j + 1];
                    matrix[m, j + 1] = temp;
                }
            }
        }
    }
}