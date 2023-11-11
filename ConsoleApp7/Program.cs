Console.WriteLine("Введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[a, b];
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; j++)
    {
        Console.WriteLine("Введите элементы массива");
        mass[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int max = 0;
for (int i = 0; i < a; i++)
{
    for (int j = 0; j < b; ++j)
    {
        if (Math.Abs(mass[i, j]) > Math.Abs(max))
        {
            max = mass[i, j];

        }
    }
}
Console.WriteLine($"Наибольшее по модулю значение будет равно {max}");

