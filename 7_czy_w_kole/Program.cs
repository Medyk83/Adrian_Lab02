using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y, r;
        Console.WriteLine("Podaj wartość x");
        x = inputValue();
        Console.WriteLine("Podaj wartość y");
        y = inputValue();
        Console.WriteLine("Podaj wartość r");
        r = inputValue();
        if (Math.Sqrt(x + y) <= Math.Sqrt(r))
        {
            Console.WriteLine("Punkt leży w obrębie koła");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Punkt leży poza obrębem koła");
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
