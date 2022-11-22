// Составить блок-схему алгоритма, вычисляющего значение функции y =ln(1 + 0.2 * x), при различных
// значениях параметра x, тзменяющегося от xn <=3 с шагом hx = -2. При этом вычислять y до тех пор,
// пока выражение под знаком логорифма остается 0. Определитть (k) вычисленных хначений y.

Console.WriteLine("Введите начало цикла(xn) : ");
double xn = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите шаг цикла(hx) : ");
double hx = Convert.ToDouble(Console.ReadLine());

double x = xn;

int k = 0;
double y = 0;
while (1 + 0.2 * x > 0)
{
    y = Math.Round(Math.Log(1 + 0.2 * x), 2);
    Console.WriteLine($"x = {x}, y = {y} ");
    k++;
    x = x + hx;
}
Console.WriteLine($"k = {k}");