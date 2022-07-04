// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

string Coord (int qr)
{
    switch (qr)
    {
        case 1:
            return "Диапозон координат x > 0 и y > 0";
        case 2:
            return "Диапозон координат x < 0 и y > 0";
        case 3:
            return "Диапозон координат x < 0 и y < 0";
        case 4:
            return "Диапозон координат x > 0 и y < 0";
        default:
            return "Введено не корректная четверть";  
    }
}
string result = Coord(quarter);
Console.WriteLine(result);