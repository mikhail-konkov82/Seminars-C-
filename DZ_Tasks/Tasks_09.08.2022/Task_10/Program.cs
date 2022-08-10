/* Задача 10: Напишите программу, 
которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Clear();
Console.WriteLine("Введите трехзначное число, ");
int number = Convert.ToInt32(Console.ReadLine());
if (Math.Abs(number) > 999 || Math.Abs(number) <= 99)
{
    Console.WriteLine("Число не трехзначное");
}
else Console.WriteLine(number / 10 % 10);