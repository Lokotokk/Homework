// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет


double[,] CreateMatrixRndDouble(int rows, int colums)
{
    double[,] matrix = new double[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble(), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

bool IsExistElement(double[,] matrix, int rows1, int colums1)
{
    if (rows1 > matrix.GetLength(0) || rows1 < 0 || colums1 > matrix.GetLength(1) || colums1 < 0) return false;
    else return true;
}

double[,] array2D = CreateMatrixRndDouble(3, 4);
PrintMatrix(array2D);

Console.WriteLine("введите позицию элемента(строка): ");
int rowsPosition = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("введите позицию элемента(столбец): ");
int columsPosition = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine(IsExistElement(array2D, rowsPosition, columsPosition) ? $"значение элемента = {array2D[rowsPosition, columsPosition]}" : "такого элемента нет");

