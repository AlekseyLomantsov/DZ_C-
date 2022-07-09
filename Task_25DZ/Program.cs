// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число A, которое надо возвести: ");
int numa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральную степень B: ");
int numb = Convert.ToInt32(Console.ReadLine());

int Digital(int number, int number2)
{
    int temp = number2;
    int temp2 = 1;
    for (int i = 0; i < number; i++)
    {
        temp2 = temp2 * temp;
    }
    return temp2;
}

int result = Digital(numb, numa );
Console.WriteLine($"Число {numa} в степени {numb} = {result}");