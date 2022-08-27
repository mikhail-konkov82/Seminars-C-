/* Задача 50. Напишите программу, которая на вход принимает число, 
и возвращает индексы этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */
Console.Clear();
Console.WriteLine();
Console.WriteLine("ввeдите кол-во строк и кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int [ , ] array = new int [n , m];
array = FillArray(array);

Console.Write("введите число для поиска х = ");

int x = Convert.ToInt32(Console.ReadLine());
IsHere(array, x);

int[,] FillArray(int [,] array)                        //заполнение массива
{   
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random().Next(0, 10);
            Console.Write("["+array[i, j]+ "] ");
        }
        Console.WriteLine();
    }
    return array;
}

void IsHere(int[,] array, int x)
{   
    for(int i = 0; i < n; i++)
    {
        for(int j = 0; j < m; j++)
        {
            if(array[i,j] == x)
            {
                Console.WriteLine("Индексы числа "+ i + ", "+ j);
                Console.WriteLine("Продолжить поиск?  1 - да, 0 - нет");
                int key = Convert.ToInt32(Console.ReadLine());
                if (key == 0){return;}
            }
        }
    }
    Console.WriteLine("Тут нет такого числа " + x);
}