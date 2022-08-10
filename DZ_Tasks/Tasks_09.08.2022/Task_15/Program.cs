/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7, ");
int x = Convert.ToInt32(Console.ReadLine());
if (x > 7 || x <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else Console.WriteLine(x >= 6 ? "да" : "нет");