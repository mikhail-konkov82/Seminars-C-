internal partial class Program
{
    private static void Main(string[] args)
    {
        // Палиндром слово читающееся в обратном порядке с сохранением смысла.


        Console.Clear();
        Console.WriteLine("Введите слово , ");
        string str = Convert.ToString(Console.ReadLine()).ToLower();
        string str2 = ReverseString(str).ToLower();
        if (str.Equals(str2)) Console.WriteLine("Палиндром");
        else Console.WriteLine("Не палиндром");

    }
    public static string ReverseString(string str)
    {
        char[] c = str.ToCharArray();
        Array.Reverse(c);
        return new string(c);
    }
}