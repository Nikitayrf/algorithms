// Составить флгоритм вычисления площади треугольника с заданными сторонами a, b, c

Console.Write("Введите сторону a : ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сторону b : ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сторону c : ");
double c = Convert.ToDouble(Console.ReadLine());

// Вычисляем полупериметр P
double p = (a + b + c) / 2;
Console.WriteLine(p);

// Вычисляем площадь треугольника S

double s = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);

Console.WriteLine($"Площадь треугольника S равна : {s}");