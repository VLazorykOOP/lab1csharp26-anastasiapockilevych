using System;
using System.Text;

public static class Tasks
{
    // Завдання 1: Розрахунок радіуса за площею
    public static double GetRadius(double s)
    {
        if (s < 0) throw new ArgumentException("Площа не може бути від'ємною");
        return Math.Sqrt(s / Math.PI);
    }

    // Завдання 2: Порівняння 1-ї та 2-ї цифри тризначного числа
    // Повертає: 1 (перша більша), 2 (друга більша), 0 (однакові)
    public static int CompareDigits(int n)
    {
        int absN = Math.Abs(n);
        if (absN < 100 || absN > 999) throw new ArgumentException("Число має бути тризначним");
        int d1 = absN / 100;
        int d2 = (absN / 10) % 10;
        if (d1 > d2) return 1;
        if (d2 > d1) return 2;
        return 0;
    }

    // Завдання 3: Перевірка потрапляння в область
    public static string CheckPoint(double x, double y)
    {
        if (x > -23 && y < 0 && y > x) return "Так";
        if ((x >= -23 && y <= 0 && y >= x) && (x == -23 || y == 0 || y == x)) return "На межі";
        return "Ні";
    }

    // Завдання 4: Східний календар
    public static string GetChineseZodiac(int year)
    {
        if (year <= 0) throw new ArgumentException("Рік має бути додатним");
        string[] animals = { "Мавпи", "Півня", "Собаки", "Свині", "Щура", "Бика", "Тигра", "Кролика", "Дракона", "Змії", "Коня", "Кози" };
        return animals[year % 12];
    }

    // Завдання 5: Квадрат різниці
    public static double SquareOfDifference(double a, double b)
    {
        return Math.Pow(a - b, 2);
    }

    // Завдання 6: Обчислення виразу
    public static double CalculateExpression(double a, double b)
    {
        double den1 = a * a + a * b + 1;
        double den2 = b * b + a * b + 1;
        if (Math.Abs(den1) < 1e-9 || Math.Abs(den2) < 1e-9)
            throw new DivideByZeroException("Ділення на нуль");

        return (1.0 / den1) - (1.0 / den2);
    }
}