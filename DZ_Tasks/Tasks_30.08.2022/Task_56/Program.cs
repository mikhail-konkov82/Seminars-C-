/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.Clear();
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
MinSumOfArrayLine(array);

int[,] FillArray(int[,] array)               //заполнение массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)                // печать массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSumOfArrayLine(int[,]array)          // нахождение строки с минимальной суммой элементов
{
    int minSum = int.MaxValue;
    int minRow = m;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        sum = SumElementsLine(array, i);
        if(minSum > sum) 
        { 
            minSum = sum;
            minRow = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Минимальная сумма элементов  = {minSum} в строке {minRow} ");
}

int SumElementsLine(int[,]array, int row)    // вычисление суммы элементов в строке
{
    int sum = 0;
    for (int j = 0 ; j < array.GetLength(1); j++)
    {
        sum += array[row , j];
    }
    Console.WriteLine($"Сумма элементов в строке {sum}");
    return sum;
}

