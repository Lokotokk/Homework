/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] array = CreateArrayRndDouble(10, 1, 10);
PrintArrayDouble(array);
double maxNum = Max(array);
Console.WriteLine($"max = {maxNum}"); 
double minNum = Min(array);
Console.WriteLine($"min = {minNum}"); 
double difference = Math.Round((maxNum - minNum), 1);
Console.WriteLine($"max - min = {difference}");


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "  ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}

double Max(double[] num)
{
    double max = num[0];
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > max) max = num[i];
    }
    return max;
}

double Min(double[] num1)
{
    double min = num1[0];
    for (int i = 0; i < num1.Length; i++)
    {
        if (num1[i] < min) min = num1[i];
    }
    return min;
}

/*double Difference();
{
    double dif = double Max() - double Min(double[] num1);
    return dif;
}*/