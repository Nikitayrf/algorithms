// Составить блок-схему алгоритма, вычисляющего значения функции y = 2 * x + 0.5, 
// при различных значения x, принадлежащих интервалу 1<= x <=3, с шагом 0,5

Console.WriteLine("Введите начало цикла(xn) : ");
double xn = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите конец цикла(xk) : ");
double xk = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите шаг цикла(hx) : ");
double hx = Convert.ToDouble(Console.ReadLine());

double x = xn;
double y = 0;

do
{
    y = 2 * x + 0.5;
    Console.Write($"x (xn) = {x}, y = {y}, xk = {xk} ");


    x = x + hx;
    Console.Write($"| x в конце цикла {x}\n");

} while (x < xk);