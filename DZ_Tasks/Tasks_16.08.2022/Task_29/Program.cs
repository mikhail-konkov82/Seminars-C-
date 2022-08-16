/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

Console.Clear();
void Fill(int[] array)
{
    int m = array.Length;
    for (int i = 0; i < m; i++)
    {
        array[i] = new Random().Next(0, 10);
        Console.Write(array[i] + ", ");
    }

}
int m = 8;
int[] array = new int[m];
Fill(array);