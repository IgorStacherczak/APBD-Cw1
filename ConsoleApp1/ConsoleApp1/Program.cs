// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 4, 6, 8 };
        
        double avg = CalculateAverage(numbers);

        Console.WriteLine("Average: " + avg);
        
        Console.WriteLine("Witaj");
    }
    
    static double CalculateAverage(int[] values)
    {
        if (values == null || values.Length == 0)
            return 0;

        int sum = 0;

        foreach (int v in values)
        {
            sum += v;
        }

        return (double)sum / values.Length;
    }
}
