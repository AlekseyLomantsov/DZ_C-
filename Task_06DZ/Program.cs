// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число,что бы узнать четное или нет");
Console.WriteLine("Введите число: ");
int first = Convert.ToInt32(Console.ReadLine());

if (first %2 == 0)
    {
        Console.WriteLine("Да, четное");
    }
else
    {
        Console.WriteLine("Нет, не четное");
    }