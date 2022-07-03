// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число");
int first = Convert.ToInt32(Console.ReadLine());

if(first % 7 == 0 && first % 23 == 0)
{
    Console.WriteLine($"{first} кратно и 7, и 23");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом чисел 7 и 23");
}