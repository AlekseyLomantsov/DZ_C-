// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();
Console.Write("Задайте первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = int.Parse(Console.ReadLine());


int AkkermanF(int m, int n)
{
if(m==0) return n+1;
else if (n==0) return AkkermanF(m-1,1);
else return AkkermanF(m-1,AkkermanF(m,n-1));
}

int resultAkk = AkkermanF(m,n);
Console.WriteLine(resultAkk);