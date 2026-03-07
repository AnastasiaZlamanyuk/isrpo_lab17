Console.WriteLine("Подъем по лестнице");
Console.Write("На какой этаж Вам нужно подняться?: ");
int targetFloor = Convert.ToInt32(Console.ReadLine());

int currentFloor = 1;
Console.WriteLine("Начинаем подъем!");
while (currentFloor < targetFloor)
{
    currentFloor++;
    Console.WriteLine($"Поднялись на {currentFloor}-й этаж");
}
Console.WriteLine($"Вы достигли {targetFloor}-го этажа!");
Console.WriteLine("Конец программы");
