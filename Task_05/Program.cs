//Задача 5. Напишите программу, которая на вход принимает
// одно число(N), а на выходе показывает все елые числа в промежутке от -N до N.


Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
for (int index = -num; index <= num; index ++)
{
    Console.Write($"{index} ");
}