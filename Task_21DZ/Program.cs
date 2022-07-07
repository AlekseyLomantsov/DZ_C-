// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты точки (A и B) ");
// Console.WriteLine("Введите координаты точки A (X Y Z через пробел)");
// int [] ayz = Console.ReadLine().Split()./*тут вставить разделитель(сейчас пробел)*/Select(int.Parse).ToArray();
// Console.WriteLine("Введите координаты точки B(X Y Z через пробел)");
// int [] byz = Console.ReadLine().Split()./*тут вставить разделитель(сейчас пробел)*/Select(int.Parse).ToArray();

Console.WriteLine("Введите координаты точки (A)");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки (B)");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Z: ");
int zb = Convert.ToInt32(Console.ReadLine());
 //                 x        y     z        x          y          z 
double Distance(int xa1, int ya1, int za1, int xb2, int yb2, int zb2)
//double Distance(int aa1, int ya1, int za1, int bb2, int yb2, int zb2)
{
    int cat1 = 0;
    int cat2 = 0;
    int cat3 = 0;
    double result = 0.0;

    cat1 = Math.Abs(xa1) - Math.Abs(xb2);
    cat2 = Math.Abs(ya1) - Math.Abs(yb2);
    cat3 = Math.Abs(za1) - Math.Abs(zb2);
    result = Math.Sqrt(cat1 * cat1 + cat2 * cat2 + cat3 * cat3);
    return Math.Round(result, 2);
}
// double result = Distance(ayz[0],ayz[1],ayz[2], byz[0],byz[1],byz[2]);
double result = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine($"Растояния между A и B: {result}");

