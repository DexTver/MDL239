using System;
namespace Function;

public static class WeStudy
{
    private static bool IsSort(string a)
    {
        string[] str = a.Split(' ');
        for (int i = 1; i < str.Length; ++i)
        {
            if (str[i - 1].Length > str[i].Length)
            {
                return false;
            }
        }
        return true;
    }

    private static bool IsPolindrom(string a)
    {
        int n = a.Length;
        for (int i = 0; i < n; ++i)
        {
            if (a[i] != a[n - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    private static string Distance(string a, string firstA, string secondB)
    {
        int start = a.IndexOf(firstA) + firstA.Length;
        int finish = a.LastIndexOf(secondB);
        return a.Substring(start, finish - start);
    }
    public static void Main(string[] args)
    {
        string x = Console.ReadLine();
        //Console.WriteLine(IsSort(x));
        //Console.WriteLine(IsPolindrom(x));
        Console.WriteLine(Distance("сегодня урок будет в дистанционном формате", "сегодня", "будет"));
    }
}