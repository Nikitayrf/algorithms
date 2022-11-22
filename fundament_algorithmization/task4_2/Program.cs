// Составить блок-счему алгоритма, вычисляющего значение функции y = 2 * x + 1, 
// при различных параметрах x, принадлежащих интервалу -3 <= x <= 3, с шагом hx = 1. В качестве
// дополнительной задачи необходимо найти: количество (k) вычисленных y, которые <=0;
// сумму (S) всех значений y и произведение (P) значений y, которые > 0.

Console.WriteLine("Введите начало цикла(xn) : ");
double xn = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите конец цикла(xk) : ");
double xk = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите шаг цикла(hx) : ");
double hx = Convert.ToDouble(Console.ReadLine());

double x = xn;
int k = 0;
double s = 0;
double p = 1;
double y = 0;

while (x <= xk)
{
    y = 2 * x + 1;
    Console.WriteLine($"x = {x}, y = {y} ");
    if (y <= 0)
    {
        k++;
    }
    else
    {
        p = p * y;
    }
    s = s + y;
    x = x + hx;
}
Console.Write($"k = {k}, P = {p}, S = {s}");