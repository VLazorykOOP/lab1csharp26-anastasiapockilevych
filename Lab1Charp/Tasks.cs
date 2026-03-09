using System;

public static class Tasks
{
    public static double GetRadius(double s)
    {
        if (s < 0) throw new ArgumentException();
        return Math.Sqrt(s / Math.PI);
    }

    public static int CompareDigits(int n)
    {
        int absN = Math.Abs(n);
        if (absN < 100 || absN > 999) throw new ArgumentException();
        int d1 = absN / 100;
        int d2 = (absN / 10) % 10;
        if (d1 > d2) return 1;
        if (d2 > d1) return 2;
        return 0;
    }

    public static string CheckPoint(double x, double y)
    {
        if (x > -23 && y < 0 && y > x) return "Так";
        if ((x >= -23 && y <= 0 && y >= x) && (x == -23 || y == 0 || y == x)) return "На межі";
        return "Ні";
    }

    public static string GetChineseZodiac(int year)
    {
        if (year <= 0) throw new ArgumentException();
        string[] animals = { "Мавпи", "Півня", "Собаки", "Свині", "Щура", "Бика", "Тигра", "Кролика", "Дракона", "Змії", "Коня", "Кози" };
        return animals[year % 12];
    }

    public static double SquareOfDifference(double a, double b)
    {
        return Math.Pow(a - b, 2);
    }

    public static double CalculateExpression(double a, double b)
    {
        double den1 = a * a + a * b + 1;
        double den2 = b * b + a * b + 1;
        if (Math.Abs(den1) < 1e-9 || Math.Abs(den2) < 1e-9)
            throw new DivideByZeroException();

        return (1.0 / den1) - (1.0 / den2);
    }
}
