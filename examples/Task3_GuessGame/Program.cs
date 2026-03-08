Random rnd = new Random();
while (true)
{
    int rndNum = rnd.Next(1, 101);
    int attempts = 0;
    Console.WriteLine("Загадано случайное число от 1 до 100");
    Console.WriteLine("(Для выхода введите 0)\n");
    while (true)
    {
        Console.Write("Введите число: ");
        if (!int.TryParse(Console.ReadLine(), out int userNum))
        {
            Console.WriteLine("Ошибка! Введите целое число.\n");
            continue;
        }
        if (userNum == 0)
        {
            Console.WriteLine($"\nВыход из игры. Загаданное число было: {rndNum}");
            return;
        }
        if (userNum < 1 || userNum > 100)
        {
            Console.WriteLine("Число должно быть от 1 до 100!\n");
            continue;
        }
        attempts++;
        if (userNum == rndNum)
        {
            Console.WriteLine($"\nВы угадали! Число {rndNum}!");
            Console.WriteLine($"Количество попыток: {attempts}");
            break;
        }
        if (userNum > rndNum)
            Console.WriteLine($"Ваше число больше (попытка №{attempts})");
        else
            Console.WriteLine($"Ваше число меньше (попытка №{attempts})");
        Console.WriteLine();
    }
    Console.WriteLine("\nХотите сыграть ещё? (да/нет)");
    string answer = Console.ReadLine().ToLower();
    if (answer == "нет" && answer == "no")
    {
        Console.WriteLine("Спасибо за игру! До свидания!");
        break;
    }
}
