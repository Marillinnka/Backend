
double firstNumber = 0;
double secondNumber = 0;
string? operation;
double result = 0;
string? repeat = "YES";

void Menu()
{
    Console.ResetColor();
    Console.WriteLine("Добро пожаловать в калькулятор.\nДоступные операции:");
    Console.WriteLine("-Сложение(+)");
    Console.WriteLine("-Вычитание(-)");
    Console.WriteLine("-Умножение(*)");
    Console.WriteLine("-Деление(:)");
    Console.WriteLine("-Возведение в степень(^)");
    Console.WriteLine("-Факториал(!).\n");
}

double Addition(double firstNumber, double secondNumber)
{
    return firstNumber + secondNumber;
}

double Difference(double firstNumber, double secondNumber)
{
    return firstNumber - secondNumber;
}

double Сomposition(double firstNumber, double secondNumber)
{
    return firstNumber * secondNumber;
}

double Division(double firstNumber, double secondNumber)
{
    if (secondNumber == 0)
    {
        throw new DivideByZeroException();
    }
    return firstNumber / secondNumber;
}

double Factorial(double firstNumber)
{
    int factorial = 1;
    for (int i = 2; i <= firstNumber; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}

double Power(double firstNumber, double secondNumber)
{
    return Math.Pow(firstNumber, secondNumber);
}

void CreateFirstNumber()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Введите первое число:");

firstNum:
    try
    {
        firstNumber = Convert.ToDouble(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ошибка! вы ввели не число\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Повторите ввод первого числа:");
        goto firstNum;
    }

}

void CreateOperation()
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Выберите одну из доступных операций и введите оператор:");

inputOperation:
    try
    {
        operation = Console.ReadLine();
        if (operation != "+" && operation != "-" && operation != "*" && operation != ":" && operation != "^" && operation != "!")
        {
            throw new Exception();
        }
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Неизвестная операция.\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Выберите одну из доступных операций и введите оператор:");
        goto inputOperation;
    }
}

void CreateSecondNumber()
{
    if (operation != "!")
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Введите второе число:");

    secondNum:
        try
        {
            secondNumber = Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка! вы ввели не число\n");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Повторите ввод второго числа:");
            goto secondNum;
        }

    }
}

void ChooseOperation()
{
    Console.ForegroundColor = ConsoleColor.Green;
    switch (operation)
    {
        case "+":
            result = Addition(firstNumber, secondNumber);
            break;

        case "-":
            result = Difference(firstNumber, secondNumber);
            break;

        case "*":
            result = Сomposition(firstNumber, secondNumber);
            break;

        case ":":
            try
            {
                result = Division(firstNumber, secondNumber);
            }
            catch (DivideByZeroException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Деление на 0 невозможно!\n");
                Console.ForegroundColor = ConsoleColor.Green;
            }
            break;

        case "!":
            result = Factorial(firstNumber);
            secondNumber = -1;
            break;

        case "^":
            result = Power(firstNumber, secondNumber);
            break;
    }
}

Menu();

while (repeat == "YES")
{
    CreateFirstNumber();
    CreateOperation();
    CreateSecondNumber();
    
    ChooseOperation();

    if(secondNumber != 0 || (secondNumber == 0 && operation != ":"))
    {
        Console.WriteLine("Результат, введённого выражения: " + result + "\n");
    }

    Console.ResetColor();
    Console.WriteLine("Вы хотите продолжить работу с калькулятором?\nВведите YES, в случае согласия.");
    repeat = Console.ReadLine();
    Console.WriteLine("\n");
}
