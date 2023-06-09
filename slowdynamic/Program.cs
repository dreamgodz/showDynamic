using System;

public class Program
{
    public static dynamic Sum(dynamic a, dynamic b)
    {
        return a + b;
    }

    public static void Main()
    {
        DateTime start = DateTime.Now;

        dynamic result = Sum("Hello", " World");

        DateTime end = DateTime.Now;

        TimeSpan time = end - start;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine("Время выполнения: " + time.TotalMilliseconds + "мс");
        Console.ReadKey();
    }
}