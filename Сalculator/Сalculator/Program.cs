
double a = 0;
double b = 0;
double result;
string? repeat = "YES";

Console.ResetColor();
Console.WriteLine("Добро пожаловать в калькулятор.\nДоступные операции:\n-Сложение(+)\n-Вычитание(-)\n-Умножение(*)\n-Деление(:)\n-Возведение в степень(^)");
Console.WriteLine("-Факториал(!).\n");

while (repeat == "YES")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Введите первое число:");
    firstNum:
    try
    {
        a = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка! вы ввели не число\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите первое число:");
        goto firstNum;
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Выберите одну из доступных операций и введите оператор:");
    string? oper = Console.ReadLine();

    if(oper != "!")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите второе число:");
        secondNum:
        try
        {
            b = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка! вы ввели не число\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Введите второе число:");
            goto secondNum;
        }

    }

    Console.ForegroundColor = ConsoleColor.Green;
    if (oper == "+")
    {
        result = a + b;
        Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".\n");
    }

    else if (oper == "-")
    {
        result = a - b;
        Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".\n");
    }

    else if (oper == "*")
    {
        result = a * b;
        Console.WriteLine( a + " умножить на " + b + " равно " + result + ".\n");
    }

    else if (oper == ":")
    {
        if (b != 0)
        {
            result = a / b;
            Console.WriteLine(+ a + " разделить на " + b + " равно " + result + ".\n");
        }
        else
        {
            Console.WriteLine("Деление на 0 невозможно!\n");
        }
    }

    else if (oper == "!")
    {
        int factorial = 1;
        for (int i = 2; i <= a; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Факториал " + a + " равен " + factorial + ".\n");
    }

    else if (oper == "^")
    {
        result = Math.Pow(a, b);
        Console.WriteLine(a + " в степени " + b + " равно " + result + ".\n");
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неизвестный оператор.\n");
    }

    Console.ResetColor();
    Console.WriteLine("Вы хотите продолжить работу с калькулятором?\nВведите YES, в случае согласия.");
    repeat = Console.ReadLine();
    Console.WriteLine("\n");
}