// Задача 19

// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число, чтобы узнать является ли оно палиндромом");
int num = Convert.ToInt32(Console.ReadLine());
if (9999<num&&num<100000)
{
int temp = num;
int temp2 = num;
int result = 0;
while (num > 0)
{
    temp2 = num % 10;
    result = result * 10 + temp2;
    num = num / 10;
}
if (temp == result)
{
    Console.WriteLine("Это палиндром");
}
else
{
    Console.WriteLine("Это НЕ палиндром");
}
}
else
{
    Console.WriteLine("Введино не пятизначно число");
}
