/*Задача 34: Задайте массив 
заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

/*По задаче 34 решение рабочее. 
Неправильно задан диапазон для массива, попадают двузначные и однозначные числа. 
Не используются параметры для max и min. ???
По задачам 36 и 38 всё верно!*/

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
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
       else Console.Write(arr[i]);
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