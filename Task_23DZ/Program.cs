﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число для создания таблици");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int squart = 0;
while(count <= num)
{
    squart = count*count*count;
    Console.WriteLine($"{count, 5} -> {squart, 5} ");
    count++;
}
