// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] numbers = CreateArray();
int countPositiveNum = CountPositiveNumbers(numbers);
Console.WriteLine($"ведено чисел больше 0: {countPositiveNum}");

int[] CreateArray()
{
    Console.WriteLine("задайте количество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("введите число: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }
    return result;
}

int CountPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0
           && array[i] != 0)
        {
            result++;
        }
    }
    return result;
}




