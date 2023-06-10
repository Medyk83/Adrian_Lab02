using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double wzrost, waga;

        Console.WriteLine("Podaj swój wzrost");
        wzrost = inputValue();
        Console.WriteLine("Podaj swoją wagę");
        waga = inputValue();
        double bmi;

        bmi = waga / (wzrost * wzrost);
        Console.WriteLine("Twoje BMI to: " + bmi);
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
