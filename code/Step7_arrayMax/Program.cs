int[] array = [1, 3, 5, 7, 9];
Console.WriteLine("Поиск максимального элемента массива");
int max = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальный элемент: {max}");