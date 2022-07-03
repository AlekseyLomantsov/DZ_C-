// Задача 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую ифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int rndNum = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {rndNum} и убераем 2 цифру и получаем:");

int firstDigit = (rndNum / 100) * 10;
int thirdDigit = (rndNum % 10);

int result = firstDigit + thirdDigit;
Console.WriteLine(result);