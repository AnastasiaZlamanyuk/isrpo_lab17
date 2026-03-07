Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру (℃): ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
    Console.WriteLine("Наденьте легкую одежду");
}
else
{
    Console.WriteLine("Наденьте теплую одежду");
}
Console.WriteLine("Хорошего дня!");