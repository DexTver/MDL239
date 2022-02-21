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
    
    private static bool IsNumber(string a)
    {
        bool ans = true, fl = false, fl2 = true;
        if (a[0] == '-') fl2 = false;
        foreach (char x in a)
        {
            if (x == 46)
            {
                if (!fl) fl = true;
                else ans = false;
            }

            else if (x == '-' + 0)
            {
                if (!fl2) fl2 = true;
                else ans = false;
            }

            else if ((x - 48) < 0 || (x - 48) > 9)
            {
                ans = false;
            }
        }

        return ans;
    }

    private static void Equation(string a, string b, string c, out string x1, out string x2)
    {
        x1 = x2 = "Нет корней";
        if (!IsNumber(a) || !IsNumber(b) || !IsNumber(c))
        {
            Console.WriteLine("Введено не число!");
            x1 = x2 = "";
        }
        else
        {
            double a1 = Double.Parse(a), b1 = Double.Parse(b), c1 = Double.Parse(c);
            if (a1 == 0f)
            {
                if (b1 == 0f)
                {
                    if (c1 == 0f)
                    {
                        x1 = x2 = "Любое число";
                    }
                    else x1 = x2 = "Нет корней";
                }
                else
                {
                    double x = -c1 / b1;
                    x1 = x.ToString();
                    x2 = "Нет корня";
                }
            }
            else
            {
                double D = (int) Math.Pow(b1, 2) - (4 * a1 * c1);
                if (D == 0)
                {
                    double x = (-b1 + Math.Sqrt(D)) / (2 * a1);
                    x1 = x.ToString();
                    x2 = "Нет корня";
                }

                if (D > 0)
                {
                    double x = (-b1 + Math.Sqrt(D)) / (2 * a1);
                    x1 = x.ToString();
                    x = (-b1 - Math.Sqrt(D)) / (2 * a1);
                    x2 = x.ToString();
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello world!)");
    }
}