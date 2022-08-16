/* Задача 25: Напишите цикл, 
который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */


Console.Clear();
void PowerB(double numberA, double numberB)
{
  double result = 1;
  for (int i = 1; i <= numberB; i++)
  {
    result *= numberA;
  }
    Console.WriteLine("Число А в степени В = " + result);
}

Console.Write("Введите число A: ");
double numberA = double.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
double numberB = double.Parse(Console.ReadLine());
PowerB(numberA, numberB);