// See https://aka.ms/new-console-template for more informatio
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("Modification 1");
        Console.WriteLine("Modification 2");
        Console.WriteLine("Modification 3");
    }

    public static double CalculateAverage(int[] arr)
    {
        return arr.Average();
    }

    public static int GetMaxValue(int[] arr)
    {
        return arr.Max();
    }
}