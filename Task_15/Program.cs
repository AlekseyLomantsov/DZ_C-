// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, выходной ли это?");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("нет"); break;//(Понедельник)
    case 2: Console.WriteLine("нет"); break;//(Вторник)
    case 3: Console.WriteLine("нет"); break;//(Среда)
    case 4: Console.WriteLine("нет"); break;//(Четверг)
    case 5: Console.WriteLine("нет"); break;//(Пятница)
    case 6: Console.WriteLine("да - выходной"); break; //(Суббота)
    case 7: Console.WriteLine("да - выходной"); break;//(Вскресенье)
    default: Console.WriteLine("Это не цифра от 1 до 7"); break;
}