﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число для создания таблици");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int squart = 0;
while(count <= num)
{
    squart = count*count;
    Console.WriteLine($"{count, 5} -> {squart, 5} ");
    count++;
}