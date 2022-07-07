// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Digital(int number)
{
    int temp= 1;
    for (int i = 1; i <= number; i++)
    {
    temp = i * temp;
    }
    return temp;
}
int result = Digital(num);
Console.WriteLine($"Произведение чисел от 1 до {num} = {result}");