// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());

bool YesOrNoTrial(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    else
    {
        return false;
    }
}

string ShowAns(bool a)
{
    if (a)
    {
        return "Такой треугольник может существовать";
    }
    else
    {
        return "Такого треугольника существовать не может";
    }
}

bool able = YesOrNoTrial(a, b, c);
string answer = ShowAns(able);
Console.WriteLine(answer);
