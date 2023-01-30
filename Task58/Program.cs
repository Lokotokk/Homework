// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] array2D = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(array2D);
Console.WriteLine(String.Empty);
int[,] array2D2 = CreateMatrixRndInt(2, 3, 1, 9);
PrintMatrix(array2D2);
Console.WriteLine(String.Empty);
if (array2D.GetLength(1) != array2D2.GetLength(0)) Console.WriteLine("перемножить матрицы невозможно");
else
{
int[,] myltiply = Multiplication(array2D, array2D2);
PrintMatrix(myltiply);
}

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

int[,] Multiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] newMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int m = 0; m < secondMatrix.GetLength(0); m++)
            {
                newMatrix[i, j] = newMatrix[i, j] + firstMatrix[i, m] * secondMatrix[m, j];
            }
        }
    }
    return newMatrix;
}

