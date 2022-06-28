// Напишите программу, которая на вход принимает два 
// числа и проверяет, является ли первое число квадратом
// второго
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> да

Console.WriteLine("Введите первое число, для проверки, является ли первое число квадратом второго");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число, для проверки, является ли первое число квадратом второго");
int second = Convert.ToInt32(Console.ReadLine());
int square = second * second;
if (square == first)
//if (second * second == first)
{
    Console.WriteLine($"Да, число {first} является квадратом числа {second}");
}
else 
{
    Console.WriteLine($"Нет, число {first}  не является квадратом числа {second}");
}
