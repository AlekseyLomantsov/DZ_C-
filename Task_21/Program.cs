// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки (A)");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки (B)");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Quarter(int xa1, int ya1, int xb2, int yb2)
{
    int cat1 = 0;
    int cat2 = 0;
    double result = 0.0;

    cat1 = Math.Abs(xa1) - Math.Abs(xb2);
    cat2 = Math.Abs(ya1) - Math.Abs(yb2);
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2);
    return Math.Round(result, 2);
}

double result = Quarter(xa, ya, xb, yb);
Console.WriteLine($"Растояние между точками A и B: {result}");