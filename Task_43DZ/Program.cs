// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.WriteLine("Введите данные для уровнений: y = k1 * x + b1, y = k2 * x + b2");

Console.Write("b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double Equations1(double b1, double k1, double b2, double k2)
{
    double x = (-b2 + b1) / (-k1 + k2);
    return x;
}

double Equations2(double x, double k2, double b2)
{
    double y = k2 * x + b2;
    return y;
}

void PrintXandY(double x, double y)
{
    Console.WriteLine($"Точка пересечения: ({x}; {y})");
}

double x = Equations1(b1, k1, b2, k2);
double y = Equations2(x, k2, b2);
PrintXandY(x, y);


