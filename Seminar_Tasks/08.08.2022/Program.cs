/* Запрашиваем через терминал размерность двухмерного массива, 
заполняем его случайными числами и считаем сумму этих чисел с выводом чисел на экран.
*/
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите размер массива m * n, ");
        int m = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int[ , ] arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {

                 arr[i , j] = new Random().Next(0, 9);
                 Console.Write(arr[i , j] + " ");
                 sum += arr[i, j];

            }
            Console.WriteLine(" ");
        }
        Console.WriteLine("Сумма всех чисел = " +sum);

    }
}
