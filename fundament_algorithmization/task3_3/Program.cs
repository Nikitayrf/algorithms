// Сщставить блок-схему алгоритма, вычисляющего значение y по одной из трёх формул, в зависимости
// от значения x.

Console.Write("Введите значение x : ");
int x = Convert.ToInt32(Console.ReadLine());
double y = 0;
if (x >= 4)
{
    y = Math.Pow(x, 2) - 4 * x;
}
else
{
    if (x < 2)
    {
        if (x + 1 != 0)
        {
            y = 3 * x / (x + 1);
        }
        else
        {
            Console.Write("Деление на 0");
            return;
        }
    }
    else
    {
        y = Math.Sqrt(x - 1.5);
    }
}
Console.WriteLine($"Значение y равно : {y}");