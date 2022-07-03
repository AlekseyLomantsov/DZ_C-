// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> не

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

if (first*first == second || second*second == first)
{
    Console.WriteLine("Числа являются квадратом друг друга");
}
else 
{
    Console.WriteLine("Числа Не являются квадратом друг друга");
}