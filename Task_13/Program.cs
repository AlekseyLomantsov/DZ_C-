// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int num3 = Convert.ToInt32(Console.ReadLine());
if (99 < num3)
{
    while (num3 > 999)
    {
        num3 = num3 / 10;
    }
    int result = num3 % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

