/*Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] array = CreateArrayRndInt(4, 100, 999);
PrintArray(array);
int countPositiveNum=CountPositiveNum(array);
Console.WriteLine($"количество чётных чисел в массиве = {countPositiveNum}");


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random(); // явная типизация
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(0, 1000);
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

int CountPositiveNum(int[] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] % 2 == 0) count++;
    }
    return count;
}