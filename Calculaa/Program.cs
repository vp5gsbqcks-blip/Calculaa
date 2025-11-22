class Calculator
{
    static void Main()
    {

        while (true)
        {
            try
            {
                Console.WriteLine("=== КАЛЬКУЛЯТОР ===\n" +
    "Доступные операции\n" +
    "1. Сложение (+)\n" +
    "2. Вычитание (-)\n" +
    "3. Умножение (*)\n" +
    "4. Деление (/)\n" +
    "5. Возведение в степень (^)\n" +
    "6. Сравнение чисел (>)\n" +
    "7. Факториал (!)\n" +
    "0. Выход\n");
                Console.Write("\nВыберите операцию (0-7): ");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    Console.WriteLine("До свидания!");
                    Console.ReadLine();
                    break;
                }
                switch (input)
                {
                    case "1":
                        Addition();
                        break;
                    case "2":
                        Subtraction();
                        break;
                    case "3":
                        Multiplication();
                        break;
                    case "4":
                        Division();
                        break;
                    case "5":
                        Power();
                        break;
                    case "6":
                        Comparison();
                        break;
                    case "7":
                        Factorial();
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        break;
                }
                Console.WriteLine("Нажмите Enter, чтобы продолжить.");
                Console.ReadLine();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    static void Addition()
    {
        Console.Clear();
        double a = GetNumber("Введите первое число: ");
        double b = GetNumber("Введите второе число: ");
        double result = a + b;
        Console.WriteLine($"Результат: {a} + {b} = {result}");
    }

    static void Subtraction()
    {
        Console.Clear();
        double a = GetNumber("Введите первое число: ");
        double b = GetNumber("Введите второе число: ");
        double result = a - b;
        Console.WriteLine($"Результат: {a} - {b} = {result}");
    }

    static void Multiplication()
    {
        Console.Clear();
        double a = GetNumber("Введите первое число: ");
        double b = GetNumber("Введите второе число: ");
        double result = a * b;
        Console.WriteLine($"Результат: {a} * {b} = {result}");
    }

    static void Division()
    {
        Console.Clear();
        double a = GetNumber("Введите делимое: ");
        double b = GetNumber("Введите делитель: ");
        if (b == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль невозможно!");
            return;
        }
        double result = a / b;
        Console.WriteLine($"Результат: {a} / {b} = {result}");
    }

    static void Power()
    {
        Console.Clear();
        double a = GetNumber("Введите основание: ");
        double b = GetNumber("Введите степень: ");
        double result = Math.Pow(a, b);
        Console.WriteLine($"Результат: {a} ^ {b} = {result}");
    }

    static void Comparison()
    {
        Console.Clear();
        double a = GetNumber("Введите первое число: ");
        double b = GetNumber("Введите второе число: ");

        if (a > b)
            Console.WriteLine($"{a} > {b} (первое число больше)");
        else if (a < b)
            Console.WriteLine($"{a} < {b} (первое число меньше)");
        else
            Console.WriteLine($"{a} = {b} (числа равны)");
    }

    static void Factorial()
    {
        Console.Clear();
        int n = (int)GetNumber("Введите число для вычисления факториала: ");
        if (n < 0)
        {
            Console.WriteLine("Ошибка: Факториал отрицательного числа не определен!");
            return;
        }
        if (n > 20)
        {
            Console.WriteLine("Ошибка: Число слишком большое для вычисления факториала!");
            return;
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine($"Результат: {n}! = {result}");
    }
    static double GetNumber(string prompt)
    {
        while (true)
        {
            try
            {
                Console.Write(prompt);
                return Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное число!");
            }
        }
    }
}