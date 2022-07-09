// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число");
int sum = Convert.ToInt32(Console.ReadLine());

int Num(int number)
{
    int sum = 0;
    int i = number;
    while (i > 0)
    {
        int temp = i % 10;
        sum = sum + temp;
        i /= 10;
    }
    return sum;
}
int result = Num(sum);
Console.WriteLine($"Сумма чисел = {result}");