// Задача 43: Напишите программу, 
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// x = (b2 - b1) / (k1 - k2)
// y = k2 * x + b2

void FillArray(double[] num)
{
    Console.WriteLine("Введите значение для b1: ");
    num[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение для k1: ");
    num[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение для b2: ");
    num[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение для k2: ");
    num[3] = Convert.ToDouble(Console.ReadLine());
}


bool IsExistCrossPoint(double[] a)
{
    if (a[1] == a[3]
    || a[0] == a[2])
        return false;
    else return true;
}

double[] Point(double[] a)
{
    double x = (a[2] - a[0]) / (a[1] - a[3]);
    double y = a[3] * x + a[2];
    return new double[] { x, y };
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("(");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ";  ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(")");
}

double[] array = new double[4];
FillArray(array);
Console.WriteLine(IsExistCrossPoint(array) ? "ecть точка пересечения" : "прямые не пересекаются, результат не корректен");
PrintArrayDouble(Point(array));







