Console.WriteLine("Калькулятор ИМТ");
Console.Write("Введите ваш вес (в кг): ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите ваш рост (в метрах): ");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
bmi = Math.Round(bmi, 1);
Console.WriteLine($"\nВаш ИМТ: {bmi}");
string category = "";
string recommendation = "";
if (bmi < 18.5)
{
category = "Недостаточный вес";
recommendation = "Увеличить калорийность питания";
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
category = "Нормальный вес";
recommendation = "Поддерживать текущий образ жизни";
}
else if (bmi >= 25 && bmi <= 29.9)
{
category = "Избыточный вес";
recommendation = "Увеличить физическую активность";
}
else
{
category = "Ожирение";
recommendation = "Обратиться к врачу-диетологу";
}
Console.WriteLine($"Категория: {category}");
Console.WriteLine($"Рекомендация: {recommendation}");