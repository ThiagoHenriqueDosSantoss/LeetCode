// See https://aka.ms/new-console-template for more information
public partial class Program
{
    public static bool IsPalindrome(int x)
    {
        int Invertido = 0;

        if (x < 0)
        {
            return false;
        }

        while (x != 0)
        {
            Invertido = Invertido * 10 + x % 10;
            x /= 10;
        }
        Console.WriteLine($"{x},{Invertido}");
        if (x != Invertido)
        {
            return false;
        }

        else if (x == Invertido)
        {
            return true;
        }
        return false;
    }


    public static void Main(String[] args)
    {
        int x = 10;
        IsPalindrome(x);
    }
}