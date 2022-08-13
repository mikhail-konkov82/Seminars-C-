/* Task from Alexey: Дан массив 5х5, вывести массив в котором каждая ячейка квадрат от ввода. */

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Начальный массива 5х5: ");
        int m = 5; int n = 5;
        int[,] arr = new int[m, n];
        Fill(arr, m, n);
        Quad(arr, m, n);
    }
    static int[,] Quad(int[,] array, int m, int n)
    {
        Console.WriteLine("Массив в квадрате");
        int[,] arr1 = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr1[i, j] = (array[i, j] * array[i, j]);
                Console.Write(arr1[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
        return arr1;

    }
    static int[,] Fill(int[,] array, int m, int n)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = new Random().Next(0, 9);
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(" ");
        }
        return array;

    }
}
