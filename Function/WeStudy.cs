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

    private static int IntLength(int x)
    {
        string a = x.ToString();
        return a.Length;
    }

    private static void Pifagor(int n = 9)
    {
        int ln = IntLength(n * n);

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write("{0}{1}", string.Concat(Enumerable.Repeat(" ", (ln - IntLength(i * j) + 1))), i * j);
            }

            Console.Write("\n");
        }
    }

    private static void Hello(int n = 20)
    {
        for (int i = 0; i < n; ++i)
        {
            Console.WriteLine("Hello");
        }
    }


    private static int Doubles()
    {
        int ans = 0;
        for (int i = 1; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                if (i + j < (i - j) * (i - j))
                {
                    Console.WriteLine(i * 10 + j);
                    ans++;
                }
            }
        }

        return ans;
    }

    private static int Thirteen()
    {
        int count = 0;
        for (int i = 104; i < 1000; i += 13)
        {
            if (i % 10 != 3) count++;
        }

        return count;
    }


    private static double Arifmetic()
    {
        int n = 0;
        double sum = 0f;
        int a = Convert.ToInt32(Console.ReadLine());
        while (a != 0)
        {
            if (a > 0)
            {
                n++;
                sum += a;
            }

            a = Convert.ToInt32(Console.ReadLine());
        }

        return sum / n;
    }

    private static string Compare()
    {
        int x = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());
        if (x == y) return "=";
        if (x > y) return ">";
        else return "<";
    }


    public static void Main(string[] args)
    {
        //string x = Console.ReadLine();
        //string first = Console.ReadLine();
        //string second = Console.ReadLine();
        //Console.WriteLine(IsSort(x));
        //Console.WriteLine(IsPolindrom(x));
        //Console.WriteLine(Distance(x, first, second));
        //Pifagor();
        //Hello();
        //Doubles();
        //Console.WriteLine(Thirteen());
        //Console.WriteLine(Arifmetic());
        //Console.WriteLine(Compare());
    }
}