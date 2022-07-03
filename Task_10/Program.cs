// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трхзначное число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (99 < num2 && num2 < 1000)
{
    int result = (num2 % 100) / 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Введено Не трехзначное число");
}
