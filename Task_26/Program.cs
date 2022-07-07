// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: "); 
// int num = Convert.ToInt32(Console.ReadLine());

// int DigitalC(int a)
// {
                                                        //не верно
//     int digital = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         a = a / 10;
//         digital++;
//     }
//     return digital;
// }
// int result = DigitalC(num);
// Console.Write($"Колличество цифр в числе {num} = {result}");

Console.WriteLine("Введите число для подсчета кол-ва чисел в нем: ");
int num = Convert.ToInt32(Console.ReadLine());

int digitsCount(int a)
{
int digitsCounter = 0;
while (a != 0)
{
a /= 10;
digitsCounter++;
}
return digitsCounter;
}
int amountOfDigits = (digitsCount(num));
Console.Write($"В числе {num} {amountOfDigits} цифры");