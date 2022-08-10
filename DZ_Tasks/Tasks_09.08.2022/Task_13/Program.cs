﻿/* Задача 13: Напишите программу,
которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */
//public int IndexOf(char value)

Console.Clear();
Console.WriteLine("Введите число, ");
string str = Console.ReadLine();        // Считали строку

int ind = 0;                            // Дополнительная переменная для расчета индекса
for (int i = 0; i < str.Length; i++)     // Пробегаем по всей строке в поисках третьей цифры
{
    if (!char.IsDigit(str[i]))           // Отсеиваем в цикле все не цифровые символы
    {
        ind++;
    }
}
if (str.Length - ind < 3) Console.WriteLine("Третьей цифры нет");  // Если строка меньше трех символов
else Console.WriteLine(str[2 + ind]);                              // Выводим третье число

