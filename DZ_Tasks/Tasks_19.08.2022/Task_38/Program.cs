/*    Задача 38: Задайте массив вещественных чисел. 
      Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76    */
Console.Clear();
double[] Mass(double[] array)
    {   
        
        int m = array.Length;
        for (int i = 0; i < m; i++)
        {
            array[i] = new Random().Next(-100, 100);
            Console.Write(array[i] + ", ");
        }
        return (array);
    } 

void Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine("Разница max - min = " + (max - min));
}

Console.Write("Введите размер массива M = ");
int m = Convert.ToInt32(Console.ReadLine());
double [] array = new double [m];
if (m <= 1)
    {
        Console.WriteLine("Размер массива мал ;-)  Пробуй еще :-) ");
        return;
    }
Mass(array);
Difference(array);