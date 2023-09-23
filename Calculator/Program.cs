using System.Diagnostics.Metrics;

double num1 = 0;
double num2 = 0;
int counter = 0;

Menu(ref num1, ref num2);
bool loop;
while (loop = true)
{
    switch (Console.ReadLine().Trim().ToUpper())
    {
        case "A":
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            counter++;
            returnToMenu();
            break;
        case "S":
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            counter++;
            returnToMenu();
            break;
        case "M":
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            counter++;
            returnToMenu();
            break;
        case "D":
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            counter++;
            returnToMenu();
            break;
        case "Q":
            Console.WriteLine("Thank you for using me");
            Environment.Exit(0);
            break;
    }
}

void Menu(ref double num1, ref double num2)
{
    Console.Clear();
    Console.WriteLine("Console Calculator\r");
    if (counter > 0)
    { Console.WriteLine($"Calculator has been used {counter} times"); }
    Console.WriteLine("------------------------------------------\n");
    Console.WriteLine("Type your first number");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Type your second number");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(@"Choose an operation
        A - Addition
        S - Subtraction
        M - Multiplication
        D - Divison
        Q - Quit");
    Console.WriteLine("------------------------------------------");
    Console.Write("Your option? ");
}

void returnToMenu()
{
    Console.Write("Press any key to return to menu");
    Console.ReadKey();
    Menu(ref num1, ref num2);
}