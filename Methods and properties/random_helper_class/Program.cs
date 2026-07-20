using System;

class RandomHelper
{
    static Random rand = new Random();

    public static int RandInt(int min, int max)
    {
        return rand.Next(min, max + 1);
    }

    public static double RandDouble(int min, int max)
    {
        return min + rand.NextDouble() * (max - min);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Random Integer: " + RandomHelper.RandInt(1, 10));
        Console.WriteLine("Random Double : " + RandomHelper.RandDouble(1, 10));
    }
}
