using System;

public class Program
{
    public static T Sum<T>(T a, T b)
    {
        if (typeof(T) == typeof(string))
        {
            string result = a.ToString() + b.ToString();
            return (T)(object)result;
        }

        throw new ArgumentException("Тип данных не поддерживается.");
    }

    public static void Main()
    {
        DateTime start = DateTime.Now;

        string result = Sum("Hello", " World");

        DateTime end = DateTime.Now;

        TimeSpan time = end - start;
        Console.WriteLine("Результат: " + result);
        Console.WriteLine("Время выполнения: " + time.TotalMilliseconds + "мс");
        Console.ReadKey();
    }
}







