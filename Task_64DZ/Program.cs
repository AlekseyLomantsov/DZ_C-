// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Задайте первое число: ");
int m = int.Parse(Console.ReadLine());
int n = 1;
NaturalNumber(m, n);

void NaturalNumber(int m, int n)
{

    if (m > n)
    {
        Console.Write($"{m} ");
        NaturalNumber(m - 1, n);
    }
    else if (m < n)
    {
        Console.Write($"{m} ");
        NaturalNumber(m + 1, n);
    }
    else
    {
        Console.Write($"{m} ");
    }
}