/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.Clear();
Console.WriteLine("введите кол-во строк, затем кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int [ , ] array = new int [n , m];
array = FillArray(array);
for (int j = 0; j < m; j++)         // Задаем номер столбца массива
{
    AvgCol(array, j);               // передаем в функцию Массив и номер интересующего нас столбца
}

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

void AvgCol(int [,] array, int j) // функция считающая ср арифм. На входе массив и номер колонки
{   
    double sum = 0;     // сумма
    for (int i = 0; i < n; i++) //   здесь перебираем ячейки столбца "j"
    {
        sum += array[i, j];     // аккумулируем в одну переменную значения
        Console.Write(array[i, j]+ " "); // выводим элементы из столбца "j"
    }
    Console.WriteLine("Ср. арифм. столбца = "+Math.Round((sum/n),2) );  // выводим значение Ср. Арифм. по столбцу "j"
}