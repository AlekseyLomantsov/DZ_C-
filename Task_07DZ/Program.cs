// Задача 7: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Программа выдает посленюю из трех цифр");
Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());
if (99 < num & num < 1000 )
{ 
    Console.WriteLine("Верно");
    int lastNumber = num % 10;
    Console.Write("Последняя цифра: ");
    Console.Write(lastNumber);
}
else
{
    Console.WriteLine("Введино не трехзначное число");
}
