/*
Задача 36: Задайте одномерный массив, 
заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] CreateArrayRndInt(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 11);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("]");
}

int SumNumInOdIndex(int[] num)
{
    int sum = 0;
    for (int i = 1; i < num.Length; i++)
    {
        if (i % 2 != 0) sum = sum + num[i];
    }
    return sum;
}


int[] array = CreateArrayRndInt(10);
PrintArray(array);
int sumNum = SumNumInOdIndex(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях = {sumNum}");