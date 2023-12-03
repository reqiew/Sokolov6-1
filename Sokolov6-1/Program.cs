using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите кол-во чисел для рассчета дисперсии");
        int n = int.Parse(Console.ReadLine());
        double[] data = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите число");
            data[i] = double.Parse(Console.ReadLine());


        }
        double mean = sumall(data);


        double variance = vr(data, mean);

        Console.WriteLine($"Дисперсия: {variance:F2}");
    }

    static double sumall(double[] data)
    {
        double sum = 0;
        foreach (double value in data)
        {
            sum += value;
        }
        double mean = sum / data.Length;

        return mean;
    }

    static double vr(double[] data, double mean)
    {
        double sum = 0;
        foreach (double value in data)
        {
            double d = value - mean;
            double ds = d * d;
            sum += ds;
        }
        double variance = sum / data.Length;

        return variance;
    }
}