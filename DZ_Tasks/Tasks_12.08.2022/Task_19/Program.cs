/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Введите пятизначное число, ");
        string str = Convert.ToString(Console.ReadLine());
        string str2 = ReverseString(str);
        if (str.Length != 5) Console.WriteLine("Ввод не верный, ");
        else Console.WriteLine(str.Equals(str2) ? "Палиндром" : "Не палиндром");
    }

    public static string ReverseString(string str)
    {
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }
}