/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29   */

Console.Clear();
Console.Write("m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"A({m},{n}) = " + Akkerman(m, n));
// Если m= 0 , то n + 1
// Если m != 0, а n = 0, то А(m-1, n)
// Если n > 0 и  m > 0 , то ф-я А(m-1, A(m, n-1))
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else
        if ((m != 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}