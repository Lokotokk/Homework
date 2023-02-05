// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("введите натуральное число");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите натуральное число");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < numberN)
{
    int sumInInterval = SumMinToMax(numberM, numberN);
    Console.WriteLine(sumInInterval);
}
else
{
    int sumInInterval2 = SumMinToMax(numberN, numberM);
    Console.WriteLine(sumInInterval2);
}

int SumMinToMax(int M, int N)
{
    if (M == N) return N;
    else return M + SumMinToMax(M + 1, N);
}



