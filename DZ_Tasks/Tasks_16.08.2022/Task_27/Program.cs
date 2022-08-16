/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

void Total(string str)
{

    int Sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        Sum = Sum + str[i] - '0';
    }
    Console.WriteLine("Сумма всех чисел: " + Sum);
}

Console.WriteLine("Введите число, ");
string str = Console.ReadLine();
Total(str);




/*string str = "452";

Console.WriteLine(str.ToCharArray().Select(ch => (int)ch -48).ToArray().Sum());*/