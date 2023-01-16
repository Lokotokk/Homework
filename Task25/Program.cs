/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b <= 0) Console.WriteLine("число должно быть натуральным");
else 
{
int degree = Degree(a,b);
Console.WriteLine($"{a},{b} -> {degree}");
}

int Degree(int x, int y)
{
    int count = 1;
    int dx = x;
    while (count < y)
    {
        x = x * dx;
        count++;
    }
    return x;
}