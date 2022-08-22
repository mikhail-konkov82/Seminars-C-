/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
void Fill(int[] array)
{
    int m = array.Length;
    int even = 0;
    for (int i = 0; i < m; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + ", ");
        if (array[i] % 2 == 0)
        {
            even++;
        }

    }
    Console.Write("-> " + even);
}

Console.WriteLine("Введите длинну массива: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 0)
{
    Console.Write("Ввод не правильный ");
}
else
{
    int[] array = new int[m];
    Fill(array);
}