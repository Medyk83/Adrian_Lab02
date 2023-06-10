using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        Console.WriteLine("Podaj pierwszy bok trójkąta");
        a = inputValue();
        Console.WriteLine("Podaj drugi bok trójkąta");
        b = inputValue();
        Console.WriteLine("Podaj trzeci bok trójkąta");
        c = inputValue();
        if (a == b && b == c && c == a)
        {
            Console.WriteLine("Z podanych przez Ciebie wartości boków można utworzyć trójkąt równoboczny");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Z podanych przez Ciebie wartości boków nie można utworzyć trójkąta równobocznego");
            Console.ReadLine();
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
