/*Задача 21
Напишите программу, 
которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();
Console.WriteLine("Введите координаты точки А ");
double[] a = new double[3];                           // инициализация пустого массива длинною в три ячейки
PointInit(a);                                         // вызов подпрограммы
Console.WriteLine("Введите координаты точки B ");
double[] b = new double[3];                           // инициализация второго массива
PointInit(b);                                         // вызов подпрограммы
Console.WriteLine("Расстояние между точками = " + Math.Round(PointDistance(a, b), 3)); // вывод в консоль результата с округлением до трех символов после запятой

double PointDistance(double[] arr1, double[] arr2)    // подпрограмма расчета расстояний
{
    return Math.Sqrt(Math.Pow((arr1[0] - arr2[0]), 2) // формула расчета
     + Math.Pow((arr1[1] - arr2[1]), 2)
     + Math.Pow((arr1[2] - arr2[2]), 2));
}
static void PointInit(double[] arr)                   // подпрограмма считывания координат
{
    arr[0] = Convert.ToDouble(Console.ReadLine());    
    arr[1] = Convert.ToDouble(Console.ReadLine());
    arr[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(string.Join("; ", arr));        // выводим полученные координаты точек

}
