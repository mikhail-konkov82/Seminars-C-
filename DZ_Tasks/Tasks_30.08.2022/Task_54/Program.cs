// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
int[,] array = new int[int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())];
FillArray(array);
Console.WriteLine();
for (int rows = 0; rows < array.GetLength(0); rows++)    // переход по строкам
    SortedArray(array, rows);
PrintArray(array);

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write("{0:d1} ", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
}
int[,] SortedArray(int[,] array, int row)
{
    int temp = 0;
    for (int z = 0; z < array.GetLength(1) - 1; z++)  // выбор элемента

        for (int i = 0; i < array.GetLength(1) - 1; i++) // перебор в строке
        {
            if (array[row, i] < array[row, i + 1])
            {
                temp = array[row, i];
                array[row, i] = array[row, i + 1];
                array[row, i + 1] = temp;
            }
        }
    return array;
}


void PrintArray(int[,] array)   // печать массива
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

