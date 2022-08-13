/*                              Задача 1.
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка и 
показывает диапазон возможных координат точек в этой четверти (x и y).
A (2, 3) -> 1 четверть, x > 0, y > 0
A (-5, -8) -> 3 четверть, x < 0, y < 0         */

Console.Clear();
Console.WriteLine("Введите координаты точки Х: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки Y: ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0) Console.Write("это первая четверть");
else if (x < 0 && y > 0) Console.Write("это вторая четверть");
else if (x < 0 && y < 0) Console.Write("это третья четверть");
else if (x > 0 && y < 0) Console.Write("это четвертая четверть");




/* Задача 2.
Напишите программу, 
которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21  */
//Console.Clear();
//Console.WriteLine("Введите координату X точки 1: ");
//int x1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату Y точки 1: ");
//int y1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату X точки 2: ");
//int x2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите координату Y точки 2: ");
//int y2 = int.Parse(Console.ReadLine());
//double ab = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
//Console.Write($"Расстояние между точек: {ab}");   

