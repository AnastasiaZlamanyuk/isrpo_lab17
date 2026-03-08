bool IsPrime(double n)
{
    if (n <= 1)
        return false;
    for (double i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
if (IsPrime(num))
{
    Console.WriteLine("Число простое");
}
else
{
    Console.WriteLine("Число не простое");
}
