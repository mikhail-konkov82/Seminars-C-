// Доп. задча: Задайте двумерный массив со случайными числами от -10 до 10. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
Console.Clear();
int n = 5;
int m = 5;
int[,] array = new int[n, m];
PrintSumDiag(FillArray(array));

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = new Random().Next(-10, 11);
            Console.Write("[" + array[i, j] + "] ");
        }
        Console.WriteLine();
    }
    return array;
}
void PrintSumDiag(int[,] arr)
{
    Console.WriteLine();
    string str = "";
    int sumDiag = 0;
    for (int i = 0; i < n; i++)
    {
        sumDiag += arr[i, i];
        // Console.Write(arr[i, i] + "+");
        str = str + '(' + arr[i, i] + ')' + '+';
    }
    Console.Write(str.Remove(str.Length - 1, 1) + " = " + sumDiag);

}
