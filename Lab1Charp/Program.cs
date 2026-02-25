using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n--- Виберіть номер завдання (1-6) або 0 для виходу ---");
            string choice = Console.ReadLine();

            if (choice == "0") break;

            switch (choice)
            {
                case "1":
                    Console.Write("Введіть площу круга (s): ");
                    if (double.TryParse(Console.ReadLine(), out double s) && s >= 0)
                    {
                        double r = Math.Sqrt(s / Math.PI);
                        Console.WriteLine($"Радіус: {r:F4}");
                    }
                    break;

                case "2":
                    Console.Write("Введіть тризначне число: ");
                    if (int.TryParse(Console.ReadLine(), out int n2))
                    {
                        int absN = Math.Abs(n2);
                        if (absN >= 100 && absN <= 999)
                        {
                            int d1 = absN / 100;
                            int d2 = (absN / 10) % 10;
                            if (d1 > d2) Console.WriteLine("Перша цифра більша");
                            else if (d2 > d1) Console.WriteLine("Друга цифра більша");
                            else Console.WriteLine("Цифри однакові");
                        }
                    }
                    break;

                case "3":
                    Console.Write("x: "); double x = double.Parse(Console.ReadLine());
                    Console.Write("y: "); double y = double.Parse(Console.ReadLine());
                    if (x > -23 && y < 0 && y > x) Console.WriteLine("Так");
                    else if ((x >= -23 && y <= 0 && y >= x) && (x == -23 || y == 0 || y == x)) Console.WriteLine("На межі");
                    else Console.WriteLine("Ні");
                    break;

                case "4":
                    Console.Write("Рік: ");
                    if (int.TryParse(Console.ReadLine(), out int yr) && yr > 0)
                    {
                        string[] animals = { "Мавпи", "Півня", "Собаки", "Свині", "Щура", "Бика", "Тигра", "Кролика", "Дракона", "Змії", "Коня", "Кози" };
                        Console.WriteLine($"Рік {animals[yr % 12]}");
                    }
                    break;

                case "5":
                    Console.Write("a: "); double a5 = double.Parse(Console.ReadLine());
                    Console.Write("b: "); double b5 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Результат: {Math.Pow(a5 - b5, 2)}");
                    break;

                case "6":
                    Console.Write("a: "); double a6 = double.Parse(Console.ReadLine());
                    Console.Write("b: "); double b6 = double.Parse(Console.ReadLine());
                    double den1 = a6 * a6 + a6 * b6 + 1;
                    double den2 = b6 * b6 + a6 * b6 + 1;
                    if (den1 != 0 && den2 != 0) Console.WriteLine($"Результат: {(1.0 / den1) - (1.0 / den2):F4}");
                    else Console.WriteLine("Ділення на нуль!");
                    break;

                default:
                    Console.WriteLine("Невірний вибір.");
                    break;
            }
        }
    }
}