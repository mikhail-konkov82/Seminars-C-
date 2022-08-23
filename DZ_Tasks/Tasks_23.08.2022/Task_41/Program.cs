﻿/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
Console.Clear();
Console.WriteLine("Введите М чисел через запятую или пробел ");
int count = 0;                                        // вводим счетчик
string[] str = Console.ReadLine().Split(',', ' ');    // считываем стоку и разбиваем ее "Split" на подстроки.Разделителея является запятая,либо пробел.
Console.Write(string.Join(", ", str));                // вывод полученного массива
foreach (string s in str)                             // цикл для каждой строки "s" массива "str"
{
    try                                               // отсеивание не корректного ввода                                         
    {
        if (Convert.ToInt32(s) > 0)                   // перебираем массив
        {
            count++;
        }
    }
    catch(Exception e)                                // как только поймали ошибку печать и выход из программы
    {
        Console.Write("Ввод не корректный ");
        break;
    }
}
Console.Write(" --> " + count);
