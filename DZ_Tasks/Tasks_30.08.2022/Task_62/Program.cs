// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int n = 4;
int[,] arr = new int[n, n];

int count = 01;
Spiral(arr, n);
PrintArray(arr);
int[,] Spiral(int[,] arr, int n)
{
    for (int dX = 0; dX < n - 1; dX++)
    {
        for (int i = 0 + dX; i < n - dX; i++)
        {
            arr[0 + dX, i] = count;
            count++;
        }
        count--;
        for (int i = 0 + dX; i < n - dX; i++)
        {
            arr[i, n - 1 - dX] = count;
            count++;
        }
        count--;
        for (int i = n - 1 - dX; i >= 0 + dX; i--)
        {
            arr[n - 1 - dX, i] = count;
            count++;
        }
        count--;
        for (int i = n - 1 - dX; i > 0 + dX; i--)
        {
            arr[i, 0 + dX] = count;
            count++;
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(" {0:D2}", arr[i, j]);
        }
        Console.WriteLine();
    }
}
