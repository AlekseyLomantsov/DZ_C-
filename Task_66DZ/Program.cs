// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке
// от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int result =NaturalNamber(m, n, sum);
Console.WriteLine(result);

int NaturalNamber(int m, int n, int sum)
{
   sum= sum+m;
   if(m>n-1 ) return sum;
   else return NaturalNamber(m+1,n,sum);
}
