/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.WriteLine("Сумма натуральных элементов в промежутке от M до N.");
Console.Write("M = ");
int m = int.Parse(Console.ReadLine());
Console.Write("N = ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

Numbers(m);

int Numbers(int m)
{
    if (m == n)
    {
        Console.WriteLine(sum += n);
        return n;
    }
    else sum += m;

    return Numbers(m + 1);

}
