double Sum(double a, double b)
{
    return a + b;
}
double Multi(double a, double b)
{
    return a * b;
}
double Div(double a, double b)
{
    return a / b;
}
double Sub(double a, double b)
{
    return a - b;
}
Console.Write("Введите 1 число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите 2 число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
double addition = Sum(num1, num2);
double multiplication = Multi(num1, num2);
double division = Div(num1, num2);
double subtraction = Sub(num1, num2);
Console.WriteLine($"{num1} + {num2} = {addition}");
Console.WriteLine($"{num1} - {num2} = {subtraction}");
Console.WriteLine($"{num1} * {num2} = {multiplication}");
Console.WriteLine($"{num1} / {num2} = {division}");