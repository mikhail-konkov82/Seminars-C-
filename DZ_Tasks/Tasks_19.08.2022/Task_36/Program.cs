/* Задача 36: Задайте одномерный массив, 
заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();

void Fill(int[] array)
{
    int m = array.Length;
    int Sum = 0;
    for (int i = 0; i < m; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + ", ");
    }
    for (int i = 1; i < m; i += 2)
    {
        Sum = Sum + array[i];
    }

    Console.Write("-> " + Sum);
}


Console.Write("Введите длинну массива: M = ");
int m = Convert.ToInt32(Console.ReadLine());
if (m <= 1)
{
    Console.WriteLine("Размер массива мал ;-)  Пробуй еще :-) ");
    return;
}
int[] array = new int[m];
Fill(array);
